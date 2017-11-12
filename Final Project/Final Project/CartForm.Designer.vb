<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CartForm
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.lblISBN = New System.Windows.Forms.Label()
        Me.lblBonus = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblCountItems = New System.Windows.Forms.Label()
        Me.btnPlace = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.radSaving = New System.Windows.Forms.RadioButton()
        Me.radNormal = New System.Windows.Forms.RadioButton()
        Me.radExpress = New System.Windows.Forms.RadioButton()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.btnPromotion = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblBonusOrder = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(26, 63)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(208, 116)
        Me.ListBox1.TabIndex = 0
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(110, 323)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(59, 17)
        Me.lblPrice.TabIndex = 25
        Me.lblPrice.Text = "Label16"
        '
        'lblAuthor
        '
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.Location = New System.Drawing.Point(110, 237)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(59, 17)
        Me.lblAuthor.TabIndex = 24
        Me.lblAuthor.Text = "Label15"
        '
        'lblISBN
        '
        Me.lblISBN.AutoSize = True
        Me.lblISBN.Location = New System.Drawing.Point(110, 267)
        Me.lblISBN.Name = "lblISBN"
        Me.lblISBN.Size = New System.Drawing.Size(59, 17)
        Me.lblISBN.TabIndex = 23
        Me.lblISBN.Text = "Label14"
        '
        'lblBonus
        '
        Me.lblBonus.AutoSize = True
        Me.lblBonus.Location = New System.Drawing.Point(110, 296)
        Me.lblBonus.Name = "lblBonus"
        Me.lblBonus.Size = New System.Drawing.Size(59, 17)
        Me.lblBonus.TabIndex = 22
        Me.lblBonus.Text = "Label13"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(110, 206)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(59, 17)
        Me.lblTitle.TabIndex = 21
        Me.lblTitle.Text = "Label12"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(33, 323)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 17)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Price:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(33, 296)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 17)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Bonus: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(33, 206)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 17)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Title:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 237)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 17)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Author:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 267)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 17)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "ISBN:"
        '
        'lblCountItems
        '
        Me.lblCountItems.AutoSize = True
        Me.lblCountItems.Location = New System.Drawing.Point(26, 31)
        Me.lblCountItems.Name = "lblCountItems"
        Me.lblCountItems.Size = New System.Drawing.Size(51, 17)
        Me.lblCountItems.TabIndex = 26
        Me.lblCountItems.Text = "Label1"
        '
        'btnPlace
        '
        Me.btnPlace.Location = New System.Drawing.Point(286, 277)
        Me.btnPlace.Name = "btnPlace"
        Me.btnPlace.Size = New System.Drawing.Size(177, 23)
        Me.btnPlace.TabIndex = 27
        Me.btnPlace.Text = "Place This Order"
        Me.btnPlace.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(533, 355)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(126, 33)
        Me.btnClose.TabIndex = 28
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(287, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Subtotal:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(287, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 17)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Promotions/Offers applied:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.radSaving)
        Me.GroupBox1.Controls.Add(Me.radNormal)
        Me.GroupBox1.Controls.Add(Me.radExpress)
        Me.GroupBox1.Location = New System.Drawing.Point(290, 143)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 111)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Please the shipping type:"
        '
        'radSaving
        '
        Me.radSaving.AutoSize = True
        Me.radSaving.Location = New System.Drawing.Point(6, 84)
        Me.radSaving.Name = "radSaving"
        Me.radSaving.Size = New System.Drawing.Size(208, 21)
        Me.radSaving.TabIndex = 2
        Me.radSaving.TabStop = True
        Me.radSaving.Text = "Saving Shipping (7-14 days)"
        Me.radSaving.UseVisualStyleBackColor = True
        '
        'radNormal
        '
        Me.radNormal.AutoSize = True
        Me.radNormal.Location = New System.Drawing.Point(6, 60)
        Me.radNormal.Name = "radNormal"
        Me.radNormal.Size = New System.Drawing.Size(202, 21)
        Me.radNormal.TabIndex = 1
        Me.radNormal.TabStop = True
        Me.radNormal.Text = "Normal Shipping (5-7 days)"
        Me.radNormal.UseVisualStyleBackColor = True
        '
        'radExpress
        '
        Me.radExpress.AutoSize = True
        Me.radExpress.Location = New System.Drawing.Point(6, 36)
        Me.radExpress.Name = "radExpress"
        Me.radExpress.Size = New System.Drawing.Size(207, 21)
        Me.radExpress.TabIndex = 0
        Me.radExpress.TabStop = True
        Me.radExpress.Text = "Express Shipping (2-3 days)"
        Me.radExpress.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(36, 355)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(133, 33)
        Me.btnDelete.TabIndex = 32
        Me.btnDelete.Text = "Delete this item"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(479, 63)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(51, 17)
        Me.lblSubtotal.TabIndex = 33
        Me.lblSubtotal.Text = "Label4"
        '
        'btnPromotion
        '
        Me.btnPromotion.AutoSize = True
        Me.btnPromotion.Location = New System.Drawing.Point(287, 123)
        Me.btnPromotion.Name = "btnPromotion"
        Me.btnPromotion.Size = New System.Drawing.Size(51, 17)
        Me.btnPromotion.TabIndex = 34
        Me.btnPromotion.Text = "Label4"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(287, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 17)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Total:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(337, 257)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(51, 17)
        Me.lblTotal.TabIndex = 36
        Me.lblTotal.Text = "Label5"
        '
        'lblBonusOrder
        '
        Me.lblBonusOrder.AutoSize = True
        Me.lblBonusOrder.Location = New System.Drawing.Point(263, 316)
        Me.lblBonusOrder.Name = "lblBonusOrder"
        Me.lblBonusOrder.Size = New System.Drawing.Size(399, 17)
        Me.lblBonusOrder.TabIndex = 37
        Me.lblBonusOrder.Text = "Note: You can get an extra bonus when purchasing over $300"
        '
        'CartForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 400)
        Me.Controls.Add(Me.lblBonusOrder)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnPromotion)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnPlace)
        Me.Controls.Add(Me.lblCountItems)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblAuthor)
        Me.Controls.Add(Me.lblISBN)
        Me.Controls.Add(Me.lblBonus)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "CartForm"
        Me.Text = "Your cart"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblAuthor As Label
    Friend WithEvents lblISBN As Label
    Friend WithEvents lblBonus As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblCountItems As Label
    Friend WithEvents btnPlace As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents radSaving As RadioButton
    Friend WithEvents radNormal As RadioButton
    Friend WithEvents radExpress As RadioButton
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents btnPromotion As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblBonusOrder As Label
End Class
