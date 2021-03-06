﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SearchForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearchTitle = New System.Windows.Forms.Button()
        Me.btnSearchISBN = New System.Windows.Forms.Button()
        Me.txtSearchISBN = New System.Windows.Forms.TextBox()
        Me.txtSearchTitle = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCart = New System.Windows.Forms.Button()
        Me.BookstoreDataSet = New Final_Project.BookstoreDataSet()
        Me.BooksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BooksTableAdapter = New Final_Project.BookstoreDataSetTableAdapters.BooksTableAdapter()
        Me.dgvBook = New System.Windows.Forms.DataGridView()
        Me.BooksOrderLineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderLineTableAdapter = New Final_Project.BookstoreDataSetTableAdapters.OrderLineTableAdapter()
        Me.BookstoreDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.txtSearchAuthor = New System.Windows.Forms.TextBox()
        Me.btnSearchAuthor = New System.Windows.Forms.Button()
        CType(Me.BookstoreDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBook, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksOrderLineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookstoreDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'btnSearchTitle
        '
        Me.btnSearchTitle.Location = New System.Drawing.Point(185, 322)
        Me.btnSearchTitle.Name = "btnSearchTitle"
        Me.btnSearchTitle.Size = New System.Drawing.Size(147, 35)
        Me.btnSearchTitle.TabIndex = 5
        Me.btnSearchTitle.Text = "Search by Title"
        Me.btnSearchTitle.UseVisualStyleBackColor = True
        '
        'btnSearchISBN
        '
        Me.btnSearchISBN.Location = New System.Drawing.Point(185, 403)
        Me.btnSearchISBN.Name = "btnSearchISBN"
        Me.btnSearchISBN.Size = New System.Drawing.Size(147, 32)
        Me.btnSearchISBN.TabIndex = 6
        Me.btnSearchISBN.Text = "Search by ISBN"
        Me.btnSearchISBN.UseVisualStyleBackColor = True
        '
        'txtSearchISBN
        '
        Me.txtSearchISBN.Location = New System.Drawing.Point(15, 408)
        Me.txtSearchISBN.Name = "txtSearchISBN"
        Me.txtSearchISBN.Size = New System.Drawing.Size(172, 22)
        Me.txtSearchISBN.TabIndex = 8
        '
        'txtSearchTitle
        '
        Me.txtSearchTitle.Location = New System.Drawing.Point(15, 328)
        Me.txtSearchTitle.Name = "txtSearchTitle"
        Me.txtSearchTitle.Size = New System.Drawing.Size(172, 22)
        Me.txtSearchTitle.TabIndex = 9
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(359, 363)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 44)
        Me.btnAdd.TabIndex = 29
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(359, 413)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 30
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
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
        'BookstoreDataSet
        '
        Me.BookstoreDataSet.DataSetName = "BookstoreDataSet"
        Me.BookstoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BooksBindingSource
        '
        Me.BooksBindingSource.DataMember = "Books"
        Me.BooksBindingSource.DataSource = Me.BookstoreDataSet
        '
        'BooksTableAdapter
        '
        Me.BooksTableAdapter.ClearBeforeFill = True
        '
        'dgvBook
        '
        Me.dgvBook.AllowUserToAddRows = False
        Me.dgvBook.AllowUserToDeleteRows = False
        Me.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBook.Location = New System.Drawing.Point(-1, 83)
        Me.dgvBook.Name = "dgvBook"
        Me.dgvBook.ReadOnly = True
        Me.dgvBook.RowTemplate.Height = 24
        Me.dgvBook.Size = New System.Drawing.Size(691, 177)
        Me.dgvBook.TabIndex = 34
        '
        'BooksOrderLineBindingSource
        '
        Me.BooksOrderLineBindingSource.DataMember = "Books_OrderLine"
        Me.BooksOrderLineBindingSource.DataSource = Me.BooksBindingSource
        '
        'OrderLineTableAdapter
        '
        Me.OrderLineTableAdapter.ClearBeforeFill = True
        '
        'BookstoreDataSetBindingSource
        '
        Me.BookstoreDataSetBindingSource.DataSource = Me.BookstoreDataSet
        Me.BookstoreDataSetBindingSource.Position = 0
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "Title", True))
        Me.lblStatus.Location = New System.Drawing.Point(12, 293)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        Me.lblStatus.TabIndex = 37
        '
        'txtSearchAuthor
        '
        Me.txtSearchAuthor.Location = New System.Drawing.Point(15, 369)
        Me.txtSearchAuthor.Name = "txtSearchAuthor"
        Me.txtSearchAuthor.Size = New System.Drawing.Size(172, 22)
        Me.txtSearchAuthor.TabIndex = 7
        '
        'btnSearchAuthor
        '
        Me.btnSearchAuthor.Location = New System.Drawing.Point(185, 363)
        Me.btnSearchAuthor.Name = "btnSearchAuthor"
        Me.btnSearchAuthor.Size = New System.Drawing.Size(147, 34)
        Me.btnSearchAuthor.TabIndex = 4
        Me.btnSearchAuthor.Text = "Search by Author"
        Me.btnSearchAuthor.UseVisualStyleBackColor = True
        '
        'SearchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 447)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.dgvBook)
        Me.Controls.Add(Me.btnCart)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtSearchTitle)
        Me.Controls.Add(Me.txtSearchISBN)
        Me.Controls.Add(Me.txtSearchAuthor)
        Me.Controls.Add(Me.btnSearchISBN)
        Me.Controls.Add(Me.btnSearchTitle)
        Me.Controls.Add(Me.btnSearchAuthor)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SearchForm"
        Me.Text = "Search & Add"
        CType(Me.BookstoreDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBook, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksOrderLineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookstoreDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearchTitle As Button
    Friend WithEvents btnSearchISBN As Button
    Friend WithEvents txtSearchISBN As TextBox
    Friend WithEvents txtSearchTitle As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCart As Button
    Friend WithEvents BookstoreDataSet As BookstoreDataSet
    Friend WithEvents BooksBindingSource As BindingSource
    Friend WithEvents BooksTableAdapter As BookstoreDataSetTableAdapters.BooksTableAdapter
    Friend WithEvents dgvBook As DataGridView
    Friend WithEvents BooksOrderLineBindingSource As BindingSource
    Friend WithEvents OrderLineTableAdapter As BookstoreDataSetTableAdapters.OrderLineTableAdapter
    Friend WithEvents BookstoreDataSetBindingSource As BindingSource
    Friend WithEvents lblStatus As Label
    Friend WithEvents txtSearchAuthor As TextBox
    Friend WithEvents btnSearchAuthor As Button
End Class
