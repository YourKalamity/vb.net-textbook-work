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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radFemale = New System.Windows.Forms.RadioButton()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rad20to60 = New System.Windows.Forms.RadioButton()
        Me.radOver60 = New System.Windows.Forms.RadioButton()
        Me.radUnder20 = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkOwnsShares = New System.Windows.Forms.CheckBox()
        Me.chkOwnsHouse = New System.Windows.Forms.CheckBox()
        Me.chkDrives = New System.Windows.Forms.CheckBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radFemale)
        Me.GroupBox1.Controls.Add(Me.radMale)
        Me.GroupBox1.Location = New System.Drawing.Point(63, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gender"
        '
        'radFemale
        '
        Me.radFemale.AutoSize = True
        Me.radFemale.Location = New System.Drawing.Point(15, 62)
        Me.radFemale.Name = "radFemale"
        Me.radFemale.Size = New System.Drawing.Size(75, 21)
        Me.radFemale.TabIndex = 1
        Me.radFemale.TabStop = True
        Me.radFemale.Text = "Female"
        Me.radFemale.UseVisualStyleBackColor = True
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Location = New System.Drawing.Point(15, 35)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(59, 21)
        Me.radMale.TabIndex = 0
        Me.radMale.TabStop = True
        Me.radMale.Text = "Male"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rad20to60)
        Me.GroupBox2.Controls.Add(Me.radOver60)
        Me.GroupBox2.Controls.Add(Me.radUnder20)
        Me.GroupBox2.Location = New System.Drawing.Point(294, 30)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 137)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Age"
        '
        'rad20to60
        '
        Me.rad20to60.AutoSize = True
        Me.rad20to60.Location = New System.Drawing.Point(25, 62)
        Me.rad20to60.Name = "rad20to60"
        Me.rad20to60.Size = New System.Drawing.Size(81, 21)
        Me.rad20to60.TabIndex = 2
        Me.rad20to60.TabStop = True
        Me.rad20to60.Text = "20 to 60"
        Me.rad20to60.UseVisualStyleBackColor = True
        '
        'radOver60
        '
        Me.radOver60.AutoSize = True
        Me.radOver60.Location = New System.Drawing.Point(25, 89)
        Me.radOver60.Name = "radOver60"
        Me.radOver60.Size = New System.Drawing.Size(80, 21)
        Me.radOver60.TabIndex = 1
        Me.radOver60.TabStop = True
        Me.radOver60.Text = "Over 60"
        Me.radOver60.UseVisualStyleBackColor = True
        '
        'radUnder20
        '
        Me.radUnder20.AutoSize = True
        Me.radUnder20.Location = New System.Drawing.Point(25, 36)
        Me.radUnder20.Name = "radUnder20"
        Me.radUnder20.Size = New System.Drawing.Size(88, 21)
        Me.radUnder20.TabIndex = 0
        Me.radUnder20.TabStop = True
        Me.radUnder20.Text = "Under 20"
        Me.radUnder20.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkOwnsShares)
        Me.GroupBox3.Controls.Add(Me.chkOwnsHouse)
        Me.GroupBox3.Controls.Add(Me.chkDrives)
        Me.GroupBox3.Location = New System.Drawing.Point(63, 204)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 112)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Replies"
        '
        'chkOwnsShares
        '
        Me.chkOwnsShares.AutoSize = True
        Me.chkOwnsShares.Location = New System.Drawing.Point(24, 84)
        Me.chkOwnsShares.Name = "chkOwnsShares"
        Me.chkOwnsShares.Size = New System.Drawing.Size(112, 21)
        Me.chkOwnsShares.TabIndex = 2
        Me.chkOwnsShares.Text = "Owns shares"
        Me.chkOwnsShares.UseVisualStyleBackColor = True
        '
        'chkOwnsHouse
        '
        Me.chkOwnsHouse.AutoSize = True
        Me.chkOwnsHouse.Location = New System.Drawing.Point(24, 57)
        Me.chkOwnsHouse.Name = "chkOwnsHouse"
        Me.chkOwnsHouse.Size = New System.Drawing.Size(120, 21)
        Me.chkOwnsHouse.TabIndex = 1
        Me.chkOwnsHouse.Text = "Owns a house"
        Me.chkOwnsHouse.UseVisualStyleBackColor = True
        '
        'chkDrives
        '
        Me.chkDrives.AutoSize = True
        Me.chkDrives.Location = New System.Drawing.Point(24, 30)
        Me.chkDrives.Name = "chkDrives"
        Me.chkDrives.Size = New System.Drawing.Size(106, 21)
        Me.chkDrives.TabIndex = 0
        Me.chkDrives.Text = "Drives a car"
        Me.chkDrives.UseVisualStyleBackColor = True
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblGender.Location = New System.Drawing.Point(60, 150)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(0, 25)
        Me.lblGender.TabIndex = 2
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 328)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "main"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents radFemale As RadioButton
    Friend WithEvents radMale As RadioButton
    Friend WithEvents chkOwnsShares As CheckBox
    Friend WithEvents chkOwnsHouse As CheckBox
    Friend WithEvents chkDrives As CheckBox
    Friend WithEvents rad20to60 As RadioButton
    Friend WithEvents radOver60 As RadioButton
    Friend WithEvents radUnder20 As RadioButton
    Friend WithEvents lblGender As Label
End Class
