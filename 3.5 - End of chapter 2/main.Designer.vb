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
        Me.lblA = New System.Windows.Forms.Label()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.lblB = New System.Windows.Forms.Label()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.lblC = New System.Windows.Forms.Label()
        Me.grpExpressions = New System.Windows.Forms.GroupBox()
        Me.radExpressionThree = New System.Windows.Forms.RadioButton()
        Me.radExpressionTwo = New System.Windows.Forms.RadioButton()
        Me.radExpressionOne = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblOut = New System.Windows.Forms.Label()
        Me.grpExpressions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblA.Location = New System.Drawing.Point(28, 33)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(26, 25)
        Me.lblA.TabIndex = 0
        Me.lblA.Text = "A"
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(67, 33)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(95, 22)
        Me.txtA.TabIndex = 1
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(67, 79)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(95, 22)
        Me.txtB.TabIndex = 3
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblB.Location = New System.Drawing.Point(28, 79)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(25, 25)
        Me.lblB.TabIndex = 2
        Me.lblB.Text = "B"
        '
        'txtC
        '
        Me.txtC.Location = New System.Drawing.Point(67, 127)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(95, 22)
        Me.txtC.TabIndex = 5
        '
        'lblC
        '
        Me.lblC.AutoSize = True
        Me.lblC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblC.Location = New System.Drawing.Point(28, 127)
        Me.lblC.Name = "lblC"
        Me.lblC.Size = New System.Drawing.Size(27, 25)
        Me.lblC.TabIndex = 4
        Me.lblC.Text = "C"
        '
        'grpExpressions
        '
        Me.grpExpressions.Controls.Add(Me.radExpressionThree)
        Me.grpExpressions.Controls.Add(Me.radExpressionTwo)
        Me.grpExpressions.Controls.Add(Me.radExpressionOne)
        Me.grpExpressions.Location = New System.Drawing.Point(187, 27)
        Me.grpExpressions.Name = "grpExpressions"
        Me.grpExpressions.Size = New System.Drawing.Size(125, 125)
        Me.grpExpressions.TabIndex = 6
        Me.grpExpressions.TabStop = False
        Me.grpExpressions.Text = "Expressions"
        '
        'radExpressionThree
        '
        Me.radExpressionThree.AutoSize = True
        Me.radExpressionThree.Location = New System.Drawing.Point(21, 84)
        Me.radExpressionThree.Name = "radExpressionThree"
        Me.radExpressionThree.Size = New System.Drawing.Size(82, 21)
        Me.radExpressionThree.TabIndex = 2
        Me.radExpressionThree.TabStop = True
        Me.radExpressionThree.Text = "B Mod C"
        Me.radExpressionThree.UseVisualStyleBackColor = True
        '
        'radExpressionTwo
        '
        Me.radExpressionTwo.AutoSize = True
        Me.radExpressionTwo.Location = New System.Drawing.Point(21, 57)
        Me.radExpressionTwo.Name = "radExpressionTwo"
        Me.radExpressionTwo.Size = New System.Drawing.Size(81, 21)
        Me.radExpressionTwo.TabIndex = 1
        Me.radExpressionTwo.TabStop = True
        Me.radExpressionTwo.Text = "A - C / B"
        Me.radExpressionTwo.UseVisualStyleBackColor = True
        '
        'radExpressionOne
        '
        Me.radExpressionOne.AutoSize = True
        Me.radExpressionOne.Location = New System.Drawing.Point(21, 30)
        Me.radExpressionOne.Name = "radExpressionOne"
        Me.radExpressionOne.Size = New System.Drawing.Size(85, 21)
        Me.radExpressionOne.TabIndex = 0
        Me.radExpressionOne.TabStop = True
        Me.radExpressionOne.Text = "A + B - C"
        Me.radExpressionOne.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(77, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Result"
        '
        'lblOut
        '
        Me.lblOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblOut.Location = New System.Drawing.Point(161, 170)
        Me.lblOut.Name = "lblOut"
        Me.lblOut.Size = New System.Drawing.Size(151, 52)
        Me.lblOut.TabIndex = 8
        Me.lblOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 231)
        Me.Controls.Add(Me.lblOut)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpExpressions)
        Me.Controls.Add(Me.txtC)
        Me.Controls.Add(Me.lblC)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.lblA)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grpExpressions.ResumeLayout(False)
        Me.grpExpressions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblA As Label
    Friend WithEvents txtA As TextBox
    Friend WithEvents txtB As TextBox
    Friend WithEvents lblB As Label
    Friend WithEvents txtC As TextBox
    Friend WithEvents lblC As Label
    Friend WithEvents grpExpressions As GroupBox
    Friend WithEvents radExpressionThree As RadioButton
    Friend WithEvents radExpressionTwo As RadioButton
    Friend WithEvents radExpressionOne As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents lblOut As Label
End Class
