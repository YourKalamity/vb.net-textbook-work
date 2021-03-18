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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.txtClub = New System.Windows.Forms.TextBox()
        Me.btnMethod1 = New System.Windows.Forms.Button()
        Me.btnMethod2 = New System.Windows.Forms.Button()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Race No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(382, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Club"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(304, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Finishing time"
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(110, 42)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(65, 22)
        Me.txtNumber.TabIndex = 4
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(110, 85)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(176, 22)
        Me.txtName.TabIndex = 5
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(441, 85)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(176, 22)
        Me.txtTime.TabIndex = 6
        '
        'txtClub
        '
        Me.txtClub.Location = New System.Drawing.Point(441, 39)
        Me.txtClub.Name = "txtClub"
        Me.txtClub.Size = New System.Drawing.Size(251, 22)
        Me.txtClub.TabIndex = 7
        '
        'btnMethod1
        '
        Me.btnMethod1.Location = New System.Drawing.Point(706, 41)
        Me.btnMethod1.Name = "btnMethod1"
        Me.btnMethod1.Size = New System.Drawing.Size(105, 44)
        Me.btnMethod1.TabIndex = 8
        Me.btnMethod1.Text = "Method 1"
        Me.btnMethod1.UseVisualStyleBackColor = True
        '
        'btnMethod2
        '
        Me.btnMethod2.Location = New System.Drawing.Point(706, 91)
        Me.btnMethod2.Name = "btnMethod2"
        Me.btnMethod2.Size = New System.Drawing.Size(105, 44)
        Me.btnMethod2.TabIndex = 9
        Me.btnMethod2.Text = "Method 2"
        Me.btnMethod2.UseVisualStyleBackColor = True
        '
        'lstOutput
        '
        Me.lstOutput.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 23
        Me.lstOutput.Location = New System.Drawing.Point(17, 153)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(675, 257)
        Me.lstOutput.TabIndex = 10
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 450)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.btnMethod2)
        Me.Controls.Add(Me.btnMethod1)
        Me.Controls.Add(Me.txtClub)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "main"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtTime As TextBox
    Friend WithEvents txtClub As TextBox
    Friend WithEvents btnMethod1 As Button
    Friend WithEvents btnMethod2 As Button
    Friend WithEvents lstOutput As ListBox
End Class
