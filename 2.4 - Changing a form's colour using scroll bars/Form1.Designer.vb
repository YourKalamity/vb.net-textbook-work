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
        Me.hsbRed = New System.Windows.Forms.HScrollBar()
        Me.hsbGreen = New System.Windows.Forms.HScrollBar()
        Me.hsbBlue = New System.Windows.Forms.HScrollBar()
        Me.lblRed = New System.Windows.Forms.Label()
        Me.lblGreen = New System.Windows.Forms.Label()
        Me.lblBlue = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'hsbRed
        '
        Me.hsbRed.Location = New System.Drawing.Point(92, 22)
        Me.hsbRed.Name = "hsbRed"
        Me.hsbRed.Size = New System.Drawing.Size(471, 62)
        Me.hsbRed.TabIndex = 0
        '
        'hsbGreen
        '
        Me.hsbGreen.Location = New System.Drawing.Point(92, 99)
        Me.hsbGreen.Name = "hsbGreen"
        Me.hsbGreen.Size = New System.Drawing.Size(471, 62)
        Me.hsbGreen.TabIndex = 1
        '
        'hsbBlue
        '
        Me.hsbBlue.Location = New System.Drawing.Point(92, 172)
        Me.hsbBlue.Name = "hsbBlue"
        Me.hsbBlue.Size = New System.Drawing.Size(471, 62)
        Me.hsbBlue.TabIndex = 2
        '
        'lblRed
        '
        Me.lblRed.AutoSize = True
        Me.lblRed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblRed.Location = New System.Drawing.Point(29, 42)
        Me.lblRed.Name = "lblRed"
        Me.lblRed.Size = New System.Drawing.Size(47, 25)
        Me.lblRed.TabIndex = 3
        Me.lblRed.Text = "Red"
        '
        'lblGreen
        '
        Me.lblGreen.AutoSize = True
        Me.lblGreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblGreen.Location = New System.Drawing.Point(23, 122)
        Me.lblGreen.Name = "lblGreen"
        Me.lblGreen.Size = New System.Drawing.Size(66, 25)
        Me.lblGreen.TabIndex = 4
        Me.lblGreen.Text = "Green"
        '
        'lblBlue
        '
        Me.lblBlue.AutoSize = True
        Me.lblBlue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblBlue.Location = New System.Drawing.Point(23, 190)
        Me.lblBlue.Name = "lblBlue"
        Me.lblBlue.Size = New System.Drawing.Size(51, 25)
        Me.lblBlue.TabIndex = 5
        Me.lblBlue.Text = "Blue"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 332)
        Me.Controls.Add(Me.lblBlue)
        Me.Controls.Add(Me.lblGreen)
        Me.Controls.Add(Me.lblRed)
        Me.Controls.Add(Me.hsbBlue)
        Me.Controls.Add(Me.hsbGreen)
        Me.Controls.Add(Me.hsbRed)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents hsbRed As HScrollBar
    Friend WithEvents hsbGreen As HScrollBar
    Friend WithEvents hsbBlue As HScrollBar
    Friend WithEvents lblRed As Label
    Friend WithEvents lblGreen As Label
    Friend WithEvents lblBlue As Label
End Class
