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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstTypes = New System.Windows.Forms.ListBox()
        Me.lstBedrooms = New System.Windows.Forms.ListBox()
        Me.btnCorrect = New System.Windows.Forms.Button()
        Me.btnIncorrect = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(284, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer wants a cottage or " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "detached property with 4 or more bedrooms"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(220, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Bedrooms"
        '
        'lstTypes
        '
        Me.lstTypes.FormattingEnabled = True
        Me.lstTypes.ItemHeight = 16
        Me.lstTypes.Items.AddRange(New Object() {"Cottage", "Detached", "Semi-detached"})
        Me.lstTypes.Location = New System.Drawing.Point(38, 86)
        Me.lstTypes.Name = "lstTypes"
        Me.lstTypes.Size = New System.Drawing.Size(130, 100)
        Me.lstTypes.TabIndex = 3
        '
        'lstBedrooms
        '
        Me.lstBedrooms.FormattingEnabled = True
        Me.lstBedrooms.ItemHeight = 16
        Me.lstBedrooms.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.lstBedrooms.Location = New System.Drawing.Point(223, 86)
        Me.lstBedrooms.Name = "lstBedrooms"
        Me.lstBedrooms.Size = New System.Drawing.Size(50, 100)
        Me.lstBedrooms.TabIndex = 4
        '
        'btnCorrect
        '
        Me.btnCorrect.Location = New System.Drawing.Point(61, 202)
        Me.btnCorrect.Name = "btnCorrect"
        Me.btnCorrect.Size = New System.Drawing.Size(86, 41)
        Me.btnCorrect.TabIndex = 5
        Me.btnCorrect.Text = "Correct"
        Me.btnCorrect.UseVisualStyleBackColor = True
        '
        'btnIncorrect
        '
        Me.btnIncorrect.Location = New System.Drawing.Point(206, 202)
        Me.btnIncorrect.Name = "btnIncorrect"
        Me.btnIncorrect.Size = New System.Drawing.Size(86, 41)
        Me.btnIncorrect.TabIndex = 6
        Me.btnIncorrect.Text = "Incorrect"
        Me.btnIncorrect.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 279)
        Me.Controls.Add(Me.btnIncorrect)
        Me.Controls.Add(Me.btnCorrect)
        Me.Controls.Add(Me.lstBedrooms)
        Me.Controls.Add(Me.lstTypes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lstTypes As ListBox
    Friend WithEvents lstBedrooms As ListBox
    Friend WithEvents btnCorrect As Button
    Friend WithEvents btnIncorrect As Button
End Class
