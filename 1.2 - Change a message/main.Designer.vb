<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnGood = New System.Windows.Forms.Button()
        Me.btnBad = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lblMessage.Location = New System.Drawing.Point(72, 67)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(252, 39)
        Me.lblMessage.TabIndex = 0
        Me.lblMessage.Text = "Click a button :)"
        '
        'btnGood
        '
        Me.btnGood.Location = New System.Drawing.Point(79, 145)
        Me.btnGood.Name = "btnGood"
        Me.btnGood.Size = New System.Drawing.Size(187, 68)
        Me.btnGood.TabIndex = 1
        Me.btnGood.Text = "Good Message"
        Me.btnGood.UseVisualStyleBackColor = True
        '
        'btnBad
        '
        Me.btnBad.Location = New System.Drawing.Point(318, 145)
        Me.btnBad.Name = "btnBad"
        Me.btnBad.Size = New System.Drawing.Size(187, 68)
        Me.btnBad.TabIndex = 2
        Me.btnBad.Text = "Bad Message"
        Me.btnBad.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 281)
        Me.Controls.Add(Me.btnBad)
        Me.Controls.Add(Me.btnGood)
        Me.Controls.Add(Me.lblMessage)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMessage As Label
    Friend WithEvents btnGood As Button
    Friend WithEvents btnBad As Button
End Class
