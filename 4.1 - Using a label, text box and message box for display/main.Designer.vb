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
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFirstNumber = New System.Windows.Forms.TextBox()
        Me.txtSecondNumber = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.btnLabel = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(796, 164)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(100, 22)
        Me.MaskedTextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(35, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "First number :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(384, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Second number :"
        '
        'txtFirstNumber
        '
        Me.txtFirstNumber.Location = New System.Drawing.Point(172, 44)
        Me.txtFirstNumber.Name = "txtFirstNumber"
        Me.txtFirstNumber.Size = New System.Drawing.Size(159, 22)
        Me.txtFirstNumber.TabIndex = 3
        '
        'txtSecondNumber
        '
        Me.txtSecondNumber.Location = New System.Drawing.Point(552, 45)
        Me.txtSecondNumber.Name = "txtSecondNumber"
        Me.txtSecondNumber.Size = New System.Drawing.Size(159, 22)
        Me.txtSecondNumber.TabIndex = 4
        '
        'lblOutput
        '
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblOutput.Location = New System.Drawing.Point(40, 88)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(291, 234)
        Me.lblOutput.TabIndex = 5
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(404, 93)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(306, 228)
        Me.txtOutput.TabIndex = 6
        '
        'btnLabel
        '
        Me.btnLabel.Location = New System.Drawing.Point(40, 353)
        Me.btnLabel.Name = "btnLabel"
        Me.btnLabel.Size = New System.Drawing.Size(75, 59)
        Me.btnLabel.TabIndex = 7
        Me.btnLabel.Text = "Label"
        Me.btnLabel.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(130, 353)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 59)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Text Box"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(224, 353)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 59)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Message Box"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnLabel)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txtSecondNumber)
        Me.Controls.Add(Me.txtFirstNumber)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Name = "main"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFirstNumber As TextBox
    Friend WithEvents txtSecondNumber As TextBox
    Friend WithEvents lblOutput As Label
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents btnLabel As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
