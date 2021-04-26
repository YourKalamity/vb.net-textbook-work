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
        Me.lstBrands = New System.Windows.Forms.ListBox()
        Me.grpItems = New System.Windows.Forms.GroupBox()
        Me.chkSpoon = New System.Windows.Forms.CheckBox()
        Me.chkFullSet = New System.Windows.Forms.CheckBox()
        Me.chkFork = New System.Windows.Forms.CheckBox()
        Me.chkKnife = New System.Windows.Forms.CheckBox()
        Me.grpQuantity = New System.Windows.Forms.GroupBox()
        Me.radEight = New System.Windows.Forms.RadioButton()
        Me.radFour = New System.Windows.Forms.RadioButton()
        Me.radTwo = New System.Windows.Forms.RadioButton()
        Me.radOne = New System.Windows.Forms.RadioButton()
        Me.btnPrice = New System.Windows.Forms.Button()
        Me.grpItems.SuspendLayout()
        Me.grpQuantity.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Brands"
        '
        'lstBrands
        '
        Me.lstBrands.ItemHeight = 16
        Me.lstBrands.Items.AddRange(New Object() {"Ardennes", "Jarrier", "Princeton", "Regency", "Tritan"})
        Me.lstBrands.Location = New System.Drawing.Point(12, 65)
        Me.lstBrands.Name = "lstBrands"
        Me.lstBrands.Size = New System.Drawing.Size(167, 180)
        Me.lstBrands.TabIndex = 0
        '
        'grpItems
        '
        Me.grpItems.Controls.Add(Me.chkSpoon)
        Me.grpItems.Controls.Add(Me.chkFullSet)
        Me.grpItems.Controls.Add(Me.chkFork)
        Me.grpItems.Controls.Add(Me.chkKnife)
        Me.grpItems.Location = New System.Drawing.Point(185, 28)
        Me.grpItems.Name = "grpItems"
        Me.grpItems.Size = New System.Drawing.Size(160, 220)
        Me.grpItems.TabIndex = 1
        Me.grpItems.TabStop = False
        Me.grpItems.Text = "Items"
        '
        'chkSpoon
        '
        Me.chkSpoon.AutoSize = True
        Me.chkSpoon.Location = New System.Drawing.Point(21, 91)
        Me.chkSpoon.Name = "chkSpoon"
        Me.chkSpoon.Size = New System.Drawing.Size(71, 21)
        Me.chkSpoon.TabIndex = 3
        Me.chkSpoon.Text = "Spoon"
        Me.chkSpoon.UseVisualStyleBackColor = True
        '
        'chkFullSet
        '
        Me.chkFullSet.AutoSize = True
        Me.chkFullSet.Location = New System.Drawing.Point(21, 162)
        Me.chkFullSet.Name = "chkFullSet"
        Me.chkFullSet.Size = New System.Drawing.Size(77, 21)
        Me.chkFullSet.TabIndex = 2
        Me.chkFullSet.Text = "Full Set"
        Me.chkFullSet.UseVisualStyleBackColor = True
        '
        'chkFork
        '
        Me.chkFork.AutoSize = True
        Me.chkFork.Location = New System.Drawing.Point(21, 64)
        Me.chkFork.Name = "chkFork"
        Me.chkFork.Size = New System.Drawing.Size(58, 21)
        Me.chkFork.TabIndex = 1
        Me.chkFork.Text = "Fork"
        Me.chkFork.UseVisualStyleBackColor = True
        '
        'chkKnife
        '
        Me.chkKnife.AutoSize = True
        Me.chkKnife.Location = New System.Drawing.Point(21, 37)
        Me.chkKnife.Name = "chkKnife"
        Me.chkKnife.Size = New System.Drawing.Size(62, 21)
        Me.chkKnife.TabIndex = 0
        Me.chkKnife.Text = "Knife"
        Me.chkKnife.UseVisualStyleBackColor = True
        '
        'grpQuantity
        '
        Me.grpQuantity.Controls.Add(Me.radEight)
        Me.grpQuantity.Controls.Add(Me.radFour)
        Me.grpQuantity.Controls.Add(Me.radTwo)
        Me.grpQuantity.Controls.Add(Me.radOne)
        Me.grpQuantity.Location = New System.Drawing.Point(351, 28)
        Me.grpQuantity.Name = "grpQuantity"
        Me.grpQuantity.Size = New System.Drawing.Size(160, 156)
        Me.grpQuantity.TabIndex = 2
        Me.grpQuantity.TabStop = False
        Me.grpQuantity.Text = "Quantity"
        '
        'radEight
        '
        Me.radEight.AutoSize = True
        Me.radEight.Location = New System.Drawing.Point(13, 102)
        Me.radEight.Name = "radEight"
        Me.radEight.Size = New System.Drawing.Size(37, 21)
        Me.radEight.TabIndex = 8
        Me.radEight.TabStop = True
        Me.radEight.Text = "8"
        Me.radEight.UseVisualStyleBackColor = True
        '
        'radFour
        '
        Me.radFour.AutoSize = True
        Me.radFour.Location = New System.Drawing.Point(13, 75)
        Me.radFour.Name = "radFour"
        Me.radFour.Size = New System.Drawing.Size(37, 21)
        Me.radFour.TabIndex = 2
        Me.radFour.TabStop = True
        Me.radFour.Text = "4"
        Me.radFour.UseVisualStyleBackColor = True
        '
        'radTwo
        '
        Me.radTwo.AutoSize = True
        Me.radTwo.Location = New System.Drawing.Point(13, 48)
        Me.radTwo.Name = "radTwo"
        Me.radTwo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.radTwo.Size = New System.Drawing.Size(37, 21)
        Me.radTwo.TabIndex = 1
        Me.radTwo.TabStop = True
        Me.radTwo.Text = "2"
        Me.radTwo.UseVisualStyleBackColor = True
        '
        'radOne
        '
        Me.radOne.AutoSize = True
        Me.radOne.Location = New System.Drawing.Point(13, 21)
        Me.radOne.Name = "radOne"
        Me.radOne.Size = New System.Drawing.Size(37, 21)
        Me.radOne.TabIndex = 0
        Me.radOne.TabStop = True
        Me.radOne.Text = "1"
        Me.radOne.UseVisualStyleBackColor = True
        '
        'btnPrice
        '
        Me.btnPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnPrice.Location = New System.Drawing.Point(364, 190)
        Me.btnPrice.Name = "btnPrice"
        Me.btnPrice.Size = New System.Drawing.Size(132, 55)
        Me.btnPrice.TabIndex = 3
        Me.btnPrice.Text = "Price"
        Me.btnPrice.UseVisualStyleBackColor = True
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 264)
        Me.Controls.Add(Me.btnPrice)
        Me.Controls.Add(Me.grpQuantity)
        Me.Controls.Add(Me.grpItems)
        Me.Controls.Add(Me.lstBrands)
        Me.Controls.Add(Me.Label1)
        Me.Name = "main"
        Me.Text = "Form1"
        Me.grpItems.ResumeLayout(False)
        Me.grpItems.PerformLayout()
        Me.grpQuantity.ResumeLayout(False)
        Me.grpQuantity.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lstBrands As ListBox
    Friend WithEvents grpItems As GroupBox
    Friend WithEvents grpQuantity As GroupBox
    Friend WithEvents btnPrice As Button
    Friend WithEvents chkSpoon As CheckBox
    Friend WithEvents chkFullSet As CheckBox
    Friend WithEvents chkFork As CheckBox
    Friend WithEvents chkKnife As CheckBox
    Friend WithEvents radEight As RadioButton
    Friend WithEvents radFour As RadioButton
    Friend WithEvents radTwo As RadioButton
    Friend WithEvents radOne As RadioButton
End Class
