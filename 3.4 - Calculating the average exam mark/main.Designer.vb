<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class txtMean
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
        Me.Label = New System.Windows.Forms.Label()
        Me.txtMark = New System.Windows.Forms.TextBox()
        Me.txtMeans = New System.Windows.Forms.TextBox()
        Me.lblMean = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnShowMean = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.lstMarks = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label.Location = New System.Drawing.Point(22, 30)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(136, 20)
        Me.Label.TabIndex = 0
        Me.Label.Text = "Enter exam mark"
        '
        'txtMark
        '
        Me.txtMark.Location = New System.Drawing.Point(174, 28)
        Me.txtMark.Name = "txtMark"
        Me.txtMark.Size = New System.Drawing.Size(103, 22)
        Me.txtMark.TabIndex = 1
        '
        'txtMeans
        '
        Me.txtMeans.Location = New System.Drawing.Point(174, 64)
        Me.txtMeans.Name = "txtMeans"
        Me.txtMeans.Size = New System.Drawing.Size(103, 22)
        Me.txtMeans.TabIndex = 3
        Me.txtMeans.Visible = False
        '
        'lblMean
        '
        Me.lblMean.AutoSize = True
        Me.lblMean.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblMean.Location = New System.Drawing.Point(22, 66)
        Me.lblMean.Name = "lblMean"
        Me.lblMean.Size = New System.Drawing.Size(137, 20)
        Me.lblMean.TabIndex = 2
        Me.lblMean.Text = "Mean exam mark"
        Me.lblMean.Visible = False
        '
        'btnOk
        '
        Me.btnOk.Enabled = False
        Me.btnOk.Location = New System.Drawing.Point(313, 32)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(103, 34)
        Me.btnOk.TabIndex = 4
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnShowMean
        '
        Me.btnShowMean.Location = New System.Drawing.Point(313, 72)
        Me.btnShowMean.Name = "btnShowMean"
        Me.btnShowMean.Size = New System.Drawing.Size(103, 34)
        Me.btnShowMean.TabIndex = 5
        Me.btnShowMean.Text = "Show Mean"
        Me.btnShowMean.UseVisualStyleBackColor = True
        Me.btnShowMean.Visible = False
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(313, 137)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(103, 34)
        Me.btnQuit.TabIndex = 6
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'lstMarks
        '
        Me.lstMarks.FormattingEnabled = True
        Me.lstMarks.ItemHeight = 16
        Me.lstMarks.Location = New System.Drawing.Point(444, 30)
        Me.lstMarks.Name = "lstMarks"
        Me.lstMarks.Size = New System.Drawing.Size(164, 132)
        Me.lstMarks.TabIndex = 7
        '
        'txtMean
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 179)
        Me.Controls.Add(Me.lstMarks)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnShowMean)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.txtMeans)
        Me.Controls.Add(Me.lblMean)
        Me.Controls.Add(Me.txtMark)
        Me.Controls.Add(Me.Label)
        Me.Name = "txtMean"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label As Label
    Friend WithEvents txtMark As TextBox
    Friend WithEvents txtMeans As TextBox
    Friend WithEvents lblMean As Label
    Friend WithEvents btnOk As Button
    Friend WithEvents btnShowMean As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents lstMarks As ListBox
End Class
