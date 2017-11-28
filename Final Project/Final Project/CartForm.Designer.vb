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
        Me.lstCart = New System.Windows.Forms.ListBox()
        Me.btnPlace = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtSubtotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radSaving = New System.Windows.Forms.RadioButton()
        Me.radNormal = New System.Windows.Forms.RadioButton()
        Me.radExpress = New System.Windows.Forms.RadioButton()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblPromotion = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblBonusOrder = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstCart
        '
        Me.lstCart.FormattingEnabled = True
        Me.lstCart.ItemHeight = 16
        Me.lstCart.Location = New System.Drawing.Point(26, 63)
        Me.lstCart.Name = "lstCart"
        Me.lstCart.Size = New System.Drawing.Size(208, 276)
        Me.lstCart.TabIndex = 0
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
        'txtSubtotal
        '
        Me.txtSubtotal.AutoSize = True
        Me.txtSubtotal.Location = New System.Drawing.Point(287, 63)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(64, 17)
        Me.txtSubtotal.TabIndex = 29
        Me.txtSubtotal.Text = "Subtotal:"
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
        Me.GroupBox1.Controls.Add(Me.radSaving)
        Me.GroupBox1.Controls.Add(Me.radNormal)
        Me.GroupBox1.Controls.Add(Me.radExpress)
        Me.GroupBox1.Location = New System.Drawing.Point(290, 143)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 111)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Please the shipping type:"
        '
        'radSaving
        '
        Me.radSaving.AutoSize = True
        Me.radSaving.Location = New System.Drawing.Point(6, 75)
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
        Me.radNormal.Location = New System.Drawing.Point(6, 48)
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
        Me.radExpress.Location = New System.Drawing.Point(7, 21)
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
        Me.lblSubtotal.Size = New System.Drawing.Size(16, 17)
        Me.lblSubtotal.TabIndex = 33
        Me.lblSubtotal.Text = "0"
        '
        'lblPromotion
        '
        Me.lblPromotion.AutoSize = True
        Me.lblPromotion.Location = New System.Drawing.Point(287, 123)
        Me.lblPromotion.Name = "lblPromotion"
        Me.lblPromotion.Size = New System.Drawing.Size(51, 17)
        Me.lblPromotion.TabIndex = 34
        Me.lblPromotion.Text = "Label4"
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
        Me.lblTotal.Size = New System.Drawing.Size(16, 17)
        Me.lblTotal.TabIndex = 36
        Me.lblTotal.Text = "0"
        '
        'lblBonusOrder
        '
        Me.lblBonusOrder.AutoSize = True
        Me.lblBonusOrder.Location = New System.Drawing.Point(263, 316)
        Me.lblBonusOrder.Name = "lblBonusOrder"
        Me.lblBonusOrder.Size = New System.Drawing.Size(391, 17)
        Me.lblBonusOrder.TabIndex = 37
        Me.lblBonusOrder.Text = "Note: You can get an extra bonus when purchasing over $60"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 17)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Your item(s):"
        '
        'CartForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 400)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblBonusOrder)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblPromotion)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnPlace)
        Me.Controls.Add(Me.lstCart)
        Me.Name = "CartForm"
        Me.Text = "Your cart"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstCart As ListBox
    Friend WithEvents btnPlace As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents txtSubtotal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radSaving As RadioButton
    Friend WithEvents radNormal As RadioButton
    Friend WithEvents radExpress As RadioButton
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblPromotion As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblBonusOrder As Label
    Friend WithEvents Label5 As Label
End Class
