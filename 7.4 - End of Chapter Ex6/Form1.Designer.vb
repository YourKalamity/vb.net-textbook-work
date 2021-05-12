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
        Me.chkHoliday = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.grpGB = New System.Windows.Forms.GroupBox()
        Me.radAbroad = New System.Windows.Forms.RadioButton()
        Me.radGB = New System.Windows.Forms.RadioButton()
        Me.grpWeeks = New System.Windows.Forms.GroupBox()
        Me.radMoreThan2 = New System.Windows.Forms.RadioButton()
        Me.radUpTo2Weeks = New System.Windows.Forms.RadioButton()
        Me.grpGB.SuspendLayout()
        Me.grpWeeks.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkHoliday
        '
        Me.chkHoliday.AutoSize = True
        Me.chkHoliday.Location = New System.Drawing.Point(28, 38)
        Me.chkHoliday.Name = "chkHoliday"
        Me.chkHoliday.Size = New System.Drawing.Size(327, 21)
        Me.chkHoliday.TabIndex = 0
        Me.chkHoliday.Text = "Have you had a holiday in the past 12 months?"
        Me.chkHoliday.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Input Data"
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(28, 209)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(124, 17)
        Me.lblNumber.TabIndex = 4
        Me.lblNumber.Text = "Number Enterd : 0"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(413, 58)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(97, 60)
        Me.btnNext.TabIndex = 5
        Me.btnNext.Text = "Next Person"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(413, 122)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(97, 60)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'grpGB
        '
        Me.grpGB.Controls.Add(Me.radAbroad)
        Me.grpGB.Controls.Add(Me.radGB)
        Me.grpGB.Location = New System.Drawing.Point(21, 75)
        Me.grpGB.Name = "grpGB"
        Me.grpGB.Size = New System.Drawing.Size(372, 55)
        Me.grpGB.TabIndex = 7
        Me.grpGB.TabStop = False
        Me.grpGB.Text = "If Yes, was it in Britain or abroad?"
        '
        'radAbroad
        '
        Me.radAbroad.AutoCheck = False
        Me.radAbroad.AutoSize = True
        Me.radAbroad.Location = New System.Drawing.Point(84, 22)
        Me.radAbroad.Name = "radAbroad"
        Me.radAbroad.Size = New System.Drawing.Size(75, 21)
        Me.radAbroad.TabIndex = 1
        Me.radAbroad.Text = "Abroad"
        Me.radAbroad.UseVisualStyleBackColor = True
        '
        'radGB
        '
        Me.radGB.AutoSize = True
        Me.radGB.Location = New System.Drawing.Point(17, 22)
        Me.radGB.Name = "radGB"
        Me.radGB.Size = New System.Drawing.Size(49, 21)
        Me.radGB.TabIndex = 0
        Me.radGB.Text = "GB"
        Me.radGB.UseVisualStyleBackColor = True
        '
        'grpWeeks
        '
        Me.grpWeeks.Controls.Add(Me.radMoreThan2)
        Me.grpWeeks.Controls.Add(Me.radUpTo2Weeks)
        Me.grpWeeks.Location = New System.Drawing.Point(28, 137)
        Me.grpWeeks.Name = "grpWeeks"
        Me.grpWeeks.Size = New System.Drawing.Size(365, 56)
        Me.grpWeeks.TabIndex = 8
        Me.grpWeeks.TabStop = False
        Me.grpWeeks.Text = "If Yes, how many weeks did it last"
        '
        'radMoreThan2
        '
        Me.radMoreThan2.AutoSize = True
        Me.radMoreThan2.Location = New System.Drawing.Point(130, 24)
        Me.radMoreThan2.Name = "radMoreThan2"
        Me.radMoreThan2.Size = New System.Drawing.Size(105, 21)
        Me.radMoreThan2.TabIndex = 3
        Me.radMoreThan2.TabStop = True
        Me.radMoreThan2.Text = "More than 2"
        Me.radMoreThan2.UseVisualStyleBackColor = True
        '
        'radUpTo2Weeks
        '
        Me.radUpTo2Weeks.AutoSize = True
        Me.radUpTo2Weeks.Location = New System.Drawing.Point(6, 24)
        Me.radUpTo2Weeks.Name = "radUpTo2Weeks"
        Me.radUpTo2Weeks.Size = New System.Drawing.Size(118, 21)
        Me.radUpTo2Weeks.TabIndex = 2
        Me.radUpTo2Weeks.TabStop = True
        Me.radUpTo2Weeks.Text = "Up to 2 weeks"
        Me.radUpTo2Weeks.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 248)
        Me.Controls.Add(Me.grpWeeks)
        Me.Controls.Add(Me.grpGB)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkHoliday)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grpGB.ResumeLayout(False)
        Me.grpGB.PerformLayout()
        Me.grpWeeks.ResumeLayout(False)
        Me.grpWeeks.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkHoliday As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNumber As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents grpGB As GroupBox
    Friend WithEvents radAbroad As RadioButton
    Friend WithEvents radGB As RadioButton
    Friend WithEvents grpWeeks As GroupBox
    Friend WithEvents radMoreThan2 As RadioButton
    Friend WithEvents radUpTo2Weeks As RadioButton
End Class
