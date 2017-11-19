<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WelcomeForm
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
        Me.components = New System.ComponentModel.Container()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnLog = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.lblISBN = New System.Windows.Forms.Label()
        Me.lblBonus = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lstNewArrivals = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblDescriptionP = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblActivePeriod = New System.Windows.Forms.Label()
        Me.lstPromotion = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BookstoreDataSet = New Final_Project.BookstoreDataSet()
        Me.Books1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Books1TableAdapter = New Final_Project.BookstoreDataSetTableAdapters.Books1TableAdapter()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BookstoreDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Books1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(646, 453)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(176, 43)
        Me.btnClose.TabIndex = 25
        Me.btnClose.Text = "E&xit"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnLog
        '
        Me.btnLog.Location = New System.Drawing.Point(94, 463)
        Me.btnLog.Name = "btnLog"
        Me.btnLog.Size = New System.Drawing.Size(125, 33)
        Me.btnLog.TabIndex = 24
        Me.btnLog.Text = "L&og In"
        Me.btnLog.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(155, 426)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 22)
        Me.txtID.TabIndex = 23
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(54, 403)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 17)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Log in:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(54, 429)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 17)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Enter your ID:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblPrice)
        Me.GroupBox2.Controls.Add(Me.lblAuthor)
        Me.GroupBox2.Controls.Add(Me.lblISBN)
        Me.GroupBox2.Controls.Add(Me.lblBonus)
        Me.GroupBox2.Controls.Add(Me.lblTitle)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.lblDate)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lstNewArrivals)
        Me.GroupBox2.Location = New System.Drawing.Point(281, 69)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(597, 363)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "New Arrivals:"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Books1BindingSource, "Price", True))
        Me.lblPrice.Location = New System.Drawing.Point(131, 325)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(61, 19)
        Me.lblPrice.TabIndex = 15
        Me.lblPrice.Text = "Label16"
        '
        'lblAuthor
        '
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAuthor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Books1BindingSource, "Author Name", True))
        Me.lblAuthor.Location = New System.Drawing.Point(71, 262)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(61, 19)
        Me.lblAuthor.TabIndex = 14
        Me.lblAuthor.Text = "Label15"
        '
        'lblISBN
        '
        Me.lblISBN.AutoSize = True
        Me.lblISBN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblISBN.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Books1BindingSource, "BookId", True))
        Me.lblISBN.Location = New System.Drawing.Point(309, 262)
        Me.lblISBN.Name = "lblISBN"
        Me.lblISBN.Size = New System.Drawing.Size(61, 19)
        Me.lblISBN.TabIndex = 13
        Me.lblISBN.Text = "Label14"
        '
        'lblBonus
        '
        Me.lblBonus.AutoSize = True
        Me.lblBonus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBonus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Books1BindingSource, "Date", True))
        Me.lblBonus.Location = New System.Drawing.Point(131, 293)
        Me.lblBonus.Name = "lblBonus"
        Me.lblBonus.Size = New System.Drawing.Size(61, 19)
        Me.lblBonus.TabIndex = 12
        Me.lblBonus.Text = "Label13"
        '
        'lblTitle
        '
        Me.lblTitle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Books1BindingSource, "Title", True))
        Me.lblTitle.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(6, 202)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(585, 47)
        Me.lblTitle.TabIndex = 11
        Me.lblTitle.Text = "Label12"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 325)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 17)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Price:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(11, 293)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(106, 17)
        Me.lblDate.TabIndex = 8
        Me.lblDate.Text = "Released Date:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 185)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Title:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 262)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Author:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(260, 262)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "ISBN:"
        '
        'lstNewArrivals
        '
        Me.lstNewArrivals.DataSource = Me.Books1BindingSource
        Me.lstNewArrivals.DisplayMember = "Title"
        Me.lstNewArrivals.FormattingEnabled = True
        Me.lstNewArrivals.ItemHeight = 16
        Me.lstNewArrivals.Location = New System.Drawing.Point(0, 34)
        Me.lstNewArrivals.Name = "lstNewArrivals"
        Me.lstNewArrivals.Size = New System.Drawing.Size(591, 148)
        Me.lstNewArrivals.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblDescriptionP)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblActivePeriod)
        Me.GroupBox1.Controls.Add(Me.lstPromotion)
        Me.GroupBox1.Location = New System.Drawing.Point(45, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(230, 297)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Active Promotions/Offers: "
        '
        'lblDescriptionP
        '
        Me.lblDescriptionP.AutoSize = True
        Me.lblDescriptionP.Location = New System.Drawing.Point(9, 250)
        Me.lblDescriptionP.Name = "lblDescriptionP"
        Me.lblDescriptionP.Size = New System.Drawing.Size(51, 17)
        Me.lblDescriptionP.TabIndex = 8
        Me.lblDescriptionP.Text = "Label5"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 232)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Description: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Active Period:"
        '
        'lblActivePeriod
        '
        Me.lblActivePeriod.AutoSize = True
        Me.lblActivePeriod.Location = New System.Drawing.Point(9, 201)
        Me.lblActivePeriod.Name = "lblActivePeriod"
        Me.lblActivePeriod.Size = New System.Drawing.Size(51, 17)
        Me.lblActivePeriod.TabIndex = 6
        Me.lblActivePeriod.Text = "Label4"
        '
        'lstPromotion
        '
        Me.lstPromotion.FormattingEnabled = True
        Me.lstPromotion.ItemHeight = 16
        Me.lstPromotion.Location = New System.Drawing.Point(6, 34)
        Me.lstPromotion.Name = "lstPromotion"
        Me.lstPromotion.Size = New System.Drawing.Size(149, 132)
        Me.lstPromotion.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Papyrus", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(51, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 31)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Welcome to My Bookstore"
        '
        'BookstoreDataSet
        '
        Me.BookstoreDataSet.DataSetName = "BookstoreDataSet"
        Me.BookstoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Books1BindingSource
        '
        Me.Books1BindingSource.DataMember = "Books1"
        Me.Books1BindingSource.DataSource = Me.BookstoreDataSet
        '
        'Books1TableAdapter
        '
        Me.Books1TableAdapter.ClearBeforeFill = True
        '
        'WelcomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 520)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnLog)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "WelcomeForm"
        Me.Text = "Welcome to My Bookstore"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BookstoreDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Books1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents btnLog As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblAuthor As Label
    Friend WithEvents lblISBN As Label
    Friend WithEvents lblBonus As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lstNewArrivals As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblDescriptionP As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblActivePeriod As Label
    Friend WithEvents lstPromotion As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BookstoreDataSet As BookstoreDataSet
    Friend WithEvents Books1BindingSource As BindingSource
    Friend WithEvents Books1TableAdapter As BookstoreDataSetTableAdapters.Books1TableAdapter
End Class
