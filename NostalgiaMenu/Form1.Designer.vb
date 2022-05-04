<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblBottom = New System.Windows.Forms.Label()
        Me.lblDefaultGame = New System.Windows.Forms.Label()
        Me.Countdown = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblBottom
        '
        Me.lblBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBottom.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBottom.Location = New System.Drawing.Point(13, 227)
        Me.lblBottom.Name = "lblBottom"
        Me.lblBottom.Size = New System.Drawing.Size(759, 25)
        Me.lblBottom.TabIndex = 0
        Me.lblBottom.Text = "Select the game you wish to boot"
        Me.lblBottom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDefaultGame
        '
        Me.lblDefaultGame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDefaultGame.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDefaultGame.Location = New System.Drawing.Point(13, 255)
        Me.lblDefaultGame.Name = "lblDefaultGame"
        Me.lblDefaultGame.Size = New System.Drawing.Size(759, 25)
        Me.lblDefaultGame.TabIndex = 1
        Me.lblDefaultGame.Text = "Default Game:"
        Me.lblDefaultGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Countdown
        '
        Me.Countdown.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1, 277)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 9)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Yuvi - 0.5"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(784, 286)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDefaultGame)
        Me.Controls.Add(Me.lblBottom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "Nostalgia Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBottom As Label
    Friend WithEvents lblDefaultGame As Label
    Friend WithEvents Countdown As Timer
    Friend WithEvents Label1 As Label
End Class
