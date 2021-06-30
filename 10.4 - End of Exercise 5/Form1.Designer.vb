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
        Me.lst_City = New System.Windows.Forms.ListBox()
        Me.lst_Countries = New System.Windows.Forms.ListBox()
        Me.lblCheck = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lst_City
        '
        Me.lst_City.FormattingEnabled = True
        Me.lst_City.ItemHeight = 16
        Me.lst_City.Items.AddRange(New Object() {"London", "Paris", "Tokyo", "Beijing", "Manila", "Washington D.C"})
        Me.lst_City.Location = New System.Drawing.Point(35, 43)
        Me.lst_City.Name = "lst_City"
        Me.lst_City.Size = New System.Drawing.Size(120, 116)
        Me.lst_City.TabIndex = 0
        '
        'lst_Countries
        '
        Me.lst_Countries.FormattingEnabled = True
        Me.lst_Countries.ItemHeight = 16
        Me.lst_Countries.Items.AddRange(New Object() {"Phillipines", "China", "USA", "Japan", "England", "France"})
        Me.lst_Countries.Location = New System.Drawing.Point(198, 43)
        Me.lst_Countries.Name = "lst_Countries"
        Me.lst_Countries.Size = New System.Drawing.Size(120, 116)
        Me.lst_Countries.TabIndex = 1
        '
        'lblCheck
        '
        Me.lblCheck.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblCheck.Location = New System.Drawing.Point(376, 27)
        Me.lblCheck.Name = "lblCheck"
        Me.lblCheck.Size = New System.Drawing.Size(173, 51)
        Me.lblCheck.TabIndex = 2
        Me.lblCheck.Text = "Enter Guess"
        Me.lblCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAnswer
        '
        Me.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblAnswer.Location = New System.Drawing.Point(341, 108)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(255, 148)
        Me.lblAnswer.TabIndex = 3
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 290)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.lblCheck)
        Me.Controls.Add(Me.lst_Countries)
        Me.Controls.Add(Me.lst_City)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lst_City As ListBox
    Friend WithEvents lst_Countries As ListBox
    Friend WithEvents lblCheck As Label
    Friend WithEvents lblAnswer As Label
End Class
