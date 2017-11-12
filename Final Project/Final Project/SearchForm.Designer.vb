<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchForm
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
        Me.lstBook = New System.Windows.Forms.ListBox()
        Me.btnAll = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearchAuthor = New System.Windows.Forms.Button()
        Me.btnSearchTitle = New System.Windows.Forms.Button()
        Me.btnSearchISBN = New System.Windows.Forms.Button()
        Me.txtSearchAuthor = New System.Windows.Forms.TextBox()
        Me.txtSearchISBN = New System.Windows.Forms.TextBox()
        Me.txtSearchTitle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCustName = New System.Windows.Forms.Label()
        Me.lblDescriptionB = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.lblISBN = New System.Windows.Forms.Label()
        Me.lblBonus = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cboQuantity = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstBook
        '
        Me.lstBook.FormattingEnabled = True
        Me.lstBook.ItemHeight = 16
        Me.lstBook.Location = New System.Drawing.Point(12, 72)
        Me.lstBook.Name = "lstBook"
        Me.lstBook.Size = New System.Drawing.Size(232, 244)
        Me.lstBook.TabIndex = 0
        '
        'btnAll
        '
        Me.btnAll.Location = New System.Drawing.Point(250, 101)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Size = New System.Drawing.Size(75, 23)
        Me.btnAll.TabIndex = 1
        Me.btnAll.Text = "All Books"
        Me.btnAll.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(250, 72)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 2
        Me.btnNew.Text = "New Books"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Searching for:"
        '
        'btnSearchAuthor
        '
        Me.btnSearchAuthor.Location = New System.Drawing.Point(169, 363)
        Me.btnSearchAuthor.Name = "btnSearchAuthor"
        Me.btnSearchAuthor.Size = New System.Drawing.Size(126, 34)
        Me.btnSearchAuthor.TabIndex = 4
        Me.btnSearchAuthor.Text = "Search by Author"
        Me.btnSearchAuthor.UseVisualStyleBackColor = True
        '
        'btnSearchTitle
        '
        Me.btnSearchTitle.Location = New System.Drawing.Point(169, 322)
        Me.btnSearchTitle.Name = "btnSearchTitle"
        Me.btnSearchTitle.Size = New System.Drawing.Size(126, 35)
        Me.btnSearchTitle.TabIndex = 5
        Me.btnSearchTitle.Text = "Search by Title"
        Me.btnSearchTitle.UseVisualStyleBackColor = True
        '
        'btnSearchISBN
        '
        Me.btnSearchISBN.Location = New System.Drawing.Point(169, 403)
        Me.btnSearchISBN.Name = "btnSearchISBN"
        Me.btnSearchISBN.Size = New System.Drawing.Size(126, 32)
        Me.btnSearchISBN.TabIndex = 6
        Me.btnSearchISBN.Text = "Search by ISBN"
        Me.btnSearchISBN.UseVisualStyleBackColor = True
        '
        'txtSearchAuthor
        '
        Me.txtSearchAuthor.Location = New System.Drawing.Point(15, 375)
        Me.txtSearchAuthor.Name = "txtSearchAuthor"
        Me.txtSearchAuthor.Size = New System.Drawing.Size(100, 22)
        Me.txtSearchAuthor.TabIndex = 7
        '
        'txtSearchISBN
        '
        Me.txtSearchISBN.Location = New System.Drawing.Point(15, 413)
        Me.txtSearchISBN.Name = "txtSearchISBN"
        Me.txtSearchISBN.Size = New System.Drawing.Size(100, 22)
        Me.txtSearchISBN.TabIndex = 8
        '
        'txtSearchTitle
        '
        Me.txtSearchTitle.Location = New System.Drawing.Point(15, 335)
        Me.txtSearchTitle.Name = "txtSearchTitle"
        Me.txtSearchTitle.Size = New System.Drawing.Size(100, 22)
        Me.txtSearchTitle.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Welcome customer:"
        '
        'lblCustName
        '
        Me.lblCustName.AutoSize = True
        Me.lblCustName.Location = New System.Drawing.Point(150, 9)
        Me.lblCustName.Name = "lblCustName"
        Me.lblCustName.Size = New System.Drawing.Size(51, 17)
        Me.lblCustName.TabIndex = 11
        Me.lblCustName.Text = "Label3"
        '
        'lblDescriptionB
        '
        Me.lblDescriptionB.AutoSize = True
        Me.lblDescriptionB.Location = New System.Drawing.Point(380, 252)
        Me.lblDescriptionB.Name = "lblDescriptionB"
        Me.lblDescriptionB.Size = New System.Drawing.Size(59, 17)
        Me.lblDescriptionB.TabIndex = 28
        Me.lblDescriptionB.Text = "Label17"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(457, 192)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(59, 17)
        Me.lblPrice.TabIndex = 27
        Me.lblPrice.Text = "Label16"
        '
        'lblAuthor
        '
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.Location = New System.Drawing.Point(457, 106)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(59, 17)
        Me.lblAuthor.TabIndex = 26
        Me.lblAuthor.Text = "Label15"
        '
        'lblISBN
        '
        Me.lblISBN.AutoSize = True
        Me.lblISBN.Location = New System.Drawing.Point(457, 136)
        Me.lblISBN.Name = "lblISBN"
        Me.lblISBN.Size = New System.Drawing.Size(59, 17)
        Me.lblISBN.TabIndex = 25
        Me.lblISBN.Text = "Label14"
        '
        'lblBonus
        '
        Me.lblBonus.AutoSize = True
        Me.lblBonus.Location = New System.Drawing.Point(457, 165)
        Me.lblBonus.Name = "lblBonus"
        Me.lblBonus.Size = New System.Drawing.Size(59, 17)
        Me.lblBonus.TabIndex = 24
        Me.lblBonus.Text = "Label13"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(457, 75)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(59, 17)
        Me.lblTitle.TabIndex = 23
        Me.lblTitle.Text = "Label12"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(380, 223)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 17)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Description:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(380, 192)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 17)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Price:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(380, 165)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 17)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Bonus: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(380, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 17)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Title:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(380, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 17)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Author:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(380, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 17)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "ISBN:"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(361, 363)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 29
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(359, 413)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cboQuantity
        '
        Me.cboQuantity.FormattingEnabled = True
        Me.cboQuantity.Location = New System.Drawing.Point(442, 322)
        Me.cboQuantity.Name = "cboQuantity"
        Me.cboQuantity.Size = New System.Drawing.Size(74, 24)
        Me.cboQuantity.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(361, 322)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Quantity:"
        '
        'btnCart
        '
        Me.btnCart.Location = New System.Drawing.Point(460, 363)
        Me.btnCart.Name = "btnCart"
        Me.btnCart.Size = New System.Drawing.Size(134, 72)
        Me.btnCart.TabIndex = 33
        Me.btnCart.Text = "Go to your cart"
        Me.btnCart.UseVisualStyleBackColor = True
        '
        'SearchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 447)
        Me.Controls.Add(Me.btnCart)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboQuantity)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblDescriptionB)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblAuthor)
        Me.Controls.Add(Me.lblISBN)
        Me.Controls.Add(Me.lblBonus)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblCustName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSearchTitle)
        Me.Controls.Add(Me.txtSearchISBN)
        Me.Controls.Add(Me.txtSearchAuthor)
        Me.Controls.Add(Me.btnSearchISBN)
        Me.Controls.Add(Me.btnSearchTitle)
        Me.Controls.Add(Me.btnSearchAuthor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnAll)
        Me.Controls.Add(Me.lstBook)
        Me.Name = "SearchForm"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstBook As ListBox
    Friend WithEvents btnAll As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearchAuthor As Button
    Friend WithEvents btnSearchTitle As Button
    Friend WithEvents btnSearchISBN As Button
    Friend WithEvents txtSearchAuthor As TextBox
    Friend WithEvents txtSearchISBN As TextBox
    Friend WithEvents txtSearchTitle As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblCustName As Label
    Friend WithEvents lblDescriptionB As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblAuthor As Label
    Friend WithEvents lblISBN As Label
    Friend WithEvents lblBonus As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents cboQuantity As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCart As Button
End Class
