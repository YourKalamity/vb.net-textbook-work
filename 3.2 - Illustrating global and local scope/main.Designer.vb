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
        Me.lblSurnameStores = New System.Windows.Forms.Label()
        Me.lblGlobal = New System.Windows.Forms.Label()
        Me.lblLocal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLocal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSurnameStores
        '
        Me.lblSurnameStores.AutoSize = True
        Me.lblSurnameStores.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblSurnameStores.Location = New System.Drawing.Point(48, 49)
        Me.lblSurnameStores.Name = "lblSurnameStores"
        Me.lblSurnameStores.Size = New System.Drawing.Size(295, 25)
        Me.lblSurnameStores.TabIndex = 0
        Me.lblSurnameStores.Text = "Global variable Surname stores: "
        '
        'lblGlobal
        '
        Me.lblGlobal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGlobal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblGlobal.Location = New System.Drawing.Point(349, 49)
        Me.lblGlobal.Name = "lblGlobal"
        Me.lblGlobal.Size = New System.Drawing.Size(183, 41)
        Me.lblGlobal.TabIndex = 1
        '
        'lblLocal
        '
        Me.lblLocal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLocal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblLocal.Location = New System.Drawing.Point(349, 121)
        Me.lblLocal.Name = "lblLocal"
        Me.lblLocal.Size = New System.Drawing.Size(183, 41)
        Me.lblLocal.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(48, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(286, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Local variable Surname stores: "
        '
        'btnLocal
        '
        Me.btnLocal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnLocal.Location = New System.Drawing.Point(349, 189)
        Me.btnLocal.Name = "btnLocal"
        Me.btnLocal.Size = New System.Drawing.Size(183, 41)
        Me.btnLocal.TabIndex = 4
        Me.btnLocal.Text = "Local"
        Me.btnLocal.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 270)
        Me.Controls.Add(Me.btnLocal)
        Me.Controls.Add(Me.lblLocal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblGlobal)
        Me.Controls.Add(Me.lblSurnameStores)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSurnameStores As Label
    Friend WithEvents lblGlobal As Label
    Friend WithEvents lblLocal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLocal As Button
End Class
