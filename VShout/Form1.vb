

Imports NetMQ
Imports NetMQ.Zyre
Imports NetMQ.Zyre.ZyreEvents


Public Class Form1

    Private _Zyre As Zyre

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ' dumb unique name
        NodeName.Text = Guid.NewGuid().ToString()

    End Sub

    ' events do not happen on main/gui thread, so we must push them off on the right thread 
    Private Sub LogString(ByVal the_log As String)
        If Me.InvokeRequired Then
            Dim args() As String = {the_log}
            Me.Invoke(New Action(Of String)(AddressOf LogString), args)
            Return
        End If
        LogBox.AppendText(the_log)
    End Sub

    ' new client joined group
    Private Sub Zyre_JoinEvent(sender As Object, e As ZyreEventJoin)
        LogString("[" + e.SenderName + "] HAS CONNECTED!" + Environment.NewLine)
    End Sub

    ' shout to a group received
    Private Sub Zyre_ShoutEvent(sender As Object, e As ZyreEventShout)
        Dim ShoutMessage As NetMQMessage

        ShoutMessage = e.Content

        ' unclear how i'm supposed to get just the actual message i put in.. but this works. 
        LogString("[" + e.SenderName + "] " + ShoutMessage.ToString() + Environment.NewLine)
    End Sub

    ' saw someone new 
    Private Sub Zyre_EnterEvent(sender As Object, e As ZyreEventEnter)
        LogString("detected new node [" + e.SenderName + "]" + Environment.NewLine)
    End Sub

    ' who knows
    Private Sub Zyre_StopEvent(sender As Object, e As ZyreEventStop)
        LogString("RECEIVED: " + e.ToString() + Environment.NewLine)
    End Sub

    ' remote client left??
    Private Sub Zyre_ExitEvent(sender As Object, e As ZyreEventExit)
        LogString("RECEIVED: " + e.ToString() + Environment.NewLine)
    End Sub

    ' heartbeat failure i think: lost touch with someone
    Private Sub Zyre_EvasiveEvent(sender As Object, e As ZyreEventEvasive)
        LogString("RECEIVED: " + e.ToString() + Environment.NewLine)
    End Sub

    ' someone leaves the group
    Private Sub Zyre_LeaveEvent(sender As Object, e As ZyreEventLeave)
        LogString("RECEIVED: " + e.ToString() + Environment.NewLine)
    End Sub

    ' direct message from a client
    Private Sub Zyre_WhisperEvent(sender As Object, e As ZyreEventWhisper)
        LogString("RECEIVED: " + e.ToString() + Environment.NewLine)
    End Sub


    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        _Zyre = New Zyre(NodeName.Text)

        NodeName.Enabled = False
        StartButton.Enabled = False
        StopButton.Enabled = True
        SendButton.Enabled = True
        CommandBox.Enabled = True

        LogBox.AppendText("starting up" + Environment.NewLine)

        AddHandler _Zyre.JoinEvent, AddressOf Zyre_JoinEvent
        AddHandler _Zyre.ShoutEvent, AddressOf Zyre_ShoutEvent
        AddHandler _Zyre.EnterEvent, AddressOf Zyre_EnterEvent
        AddHandler _Zyre.StopEvent, AddressOf Zyre_StopEvent
        AddHandler _Zyre.ExitEvent, AddressOf Zyre_ExitEvent
        AddHandler _Zyre.EvasiveEvent, AddressOf Zyre_EvasiveEvent
        AddHandler _Zyre.LeaveEvent, AddressOf Zyre_LeaveEvent
        AddHandler _Zyre.WhisperEvent, AddressOf Zyre_WhisperEvent

        ' set public name
        _Zyre.SetName(NodeName.Text)
        _Zyre.Start() ' starts broadcast discovery
        _Zyre.Join("HappyGroup") ' join a group: fixed name for now

    End Sub

    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click
        NodeName.Enabled = True
        StartButton.Enabled = True
        StopButton.Enabled = False
        SendButton.Enabled = False
        CommandBox.Enabled = False

        _Zyre.Stop()
        _Zyre = Nothing
    End Sub

    Private Sub SendButton_Click(sender As Object, e As EventArgs) Handles SendButton.Click
        Dim ShoutMessage As NetMQMessage

        ShoutMessage = New NetMQMessage()

        ShoutMessage.Append(CommandBox.Text)
        _Zyre.Shout("HappyGroup", ShoutMessage) ' send message to group, in this case HappyGroup

        LogBox.AppendText("SHOUT: " + CommandBox.Text + Environment.NewLine)
        CommandBox.Text = ""

    End Sub
End Class
