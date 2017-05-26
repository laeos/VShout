<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.StopButton = New System.Windows.Forms.Button()
        Me.CommandBox = New System.Windows.Forms.TextBox()
        Me.SendButton = New System.Windows.Forms.Button()
        Me.LogBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NodeName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'StartButton
        '
        Me.StartButton.Location = New System.Drawing.Point(16, 80)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(195, 50)
        Me.StartButton.TabIndex = 0
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'StopButton
        '
        Me.StopButton.Enabled = False
        Me.StopButton.Location = New System.Drawing.Point(236, 80)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(195, 50)
        Me.StopButton.TabIndex = 1
        Me.StopButton.Text = "Stop"
        Me.StopButton.UseVisualStyleBackColor = True
        '
        'CommandBox
        '
        Me.CommandBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.CommandBox.Enabled = False
        Me.CommandBox.Location = New System.Drawing.Point(16, 168)
        Me.CommandBox.Name = "CommandBox"
        Me.CommandBox.Size = New System.Drawing.Size(832, 26)
        Me.CommandBox.TabIndex = 3
        '
        'SendButton
        '
        Me.SendButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SendButton.Enabled = False
        Me.SendButton.Location = New System.Drawing.Point(854, 156)
        Me.SendButton.Name = "SendButton"
        Me.SendButton.Size = New System.Drawing.Size(90, 50)
        Me.SendButton.TabIndex = 4
        Me.SendButton.Text = "Send!"
        Me.SendButton.UseVisualStyleBackColor = True
        '
        'LogBox
        '
        Me.LogBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LogBox.Location = New System.Drawing.Point(12, 259)
        Me.LogBox.Multiline = True
        Me.LogBox.Name = "LogBox"
        Me.LogBox.ReadOnly = True
        Me.LogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.LogBox.Size = New System.Drawing.Size(1799, 572)
        Me.LogBox.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 236)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Output Log"
        '
        'NodeName
        '
        Me.NodeName.Location = New System.Drawing.Point(213, 23)
        Me.NodeName.Name = "NodeName"
        Me.NodeName.Size = New System.Drawing.Size(380, 26)
        Me.NodeName.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(195, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Enter Unique Node Name:"
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(462, 80)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(195, 50)
        Me.ClearButton.TabIndex = 11
        Me.ClearButton.Text = "Clear Output"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1823, 843)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NodeName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LogBox)
        Me.Controls.Add(Me.SendButton)
        Me.Controls.Add(Me.CommandBox)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.StartButton)
        Me.Name = "Form1"
        Me.Text = "VShout"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StartButton As Button
    Friend WithEvents StopButton As Button
    Friend WithEvents CommandBox As TextBox
    Friend WithEvents SendButton As Button
    Friend WithEvents LogBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NodeName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ClearButton As Button
End Class
