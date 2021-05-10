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
        Me.lstWards = New System.Windows.Forms.ListBox()
        Me.lstPatients = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Wards"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(218, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Patients"
        '
        'lstWards
        '
        Me.lstWards.FormattingEnabled = True
        Me.lstWards.ItemHeight = 16
        Me.lstWards.Items.AddRange(New Object() {"Fleming", "Harvey", "Jenner"})
        Me.lstWards.Location = New System.Drawing.Point(37, 64)
        Me.lstWards.Name = "lstWards"
        Me.lstWards.Size = New System.Drawing.Size(120, 84)
        Me.lstWards.TabIndex = 2
        '
        'lstPatients
        '
        Me.lstPatients.FormattingEnabled = True
        Me.lstPatients.ItemHeight = 16
        Me.lstPatients.Location = New System.Drawing.Point(212, 64)
        Me.lstPatients.Name = "lstPatients"
        Me.lstPatients.Size = New System.Drawing.Size(120, 84)
        Me.lstPatients.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 185)
        Me.Controls.Add(Me.lstPatients)
        Me.Controls.Add(Me.lstWards)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Program 6.4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lstWards As ListBox
    Friend WithEvents lstPatients As ListBox
End Class
