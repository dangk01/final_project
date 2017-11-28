Public Class SearchForm
    Private mBooks As New Books
    Private formLoading As Boolean = True
    Dim cart As New CartForm


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnCart_Click(sender As Object, e As EventArgs) Handles btnCart.Click
        CartForm.ShowDialog()


    End Sub

    Private Sub SearchForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''TODO: This line of code loads data into the 'BookstoreDataSet.OrderLine' table. You can move, or remove it, as needed.
        'Me.OrderLineTableAdapter.Fill(Me.BookstoreDataSet.OrderLine)
        ''TODO: This line of code loads data into the 'BookstoreDataSet.Books' table. You can move, or remove it, as needed.
        'Me.BooksTableAdapter.Fill(Me.BookstoreDataSet.Books)

        dgvBook.DataSource = mBooks.Items

    End Sub

    Private Sub btnSearchISBN_Click(sender As Object, e As EventArgs) Handles btnSearchISBN.Click
        lblStatus.Text = ""
        Dim bookId As Integer
        If Integer.TryParse(txtSearchISBN.Text, bookId) Then
            dgvBook.DataSource = mBooks.GetByBookID(bookId)
        Else
            lblStatus.Text = "This is not a valid ISBN. Please enter again!"
            txtSearchISBN.Text = ""
            Return

        End If

    End Sub

    Private Sub btnSearchTitle_Click(sender As Object, e As EventArgs) Handles btnSearchTitle.Click
        Dim bookName As String
        lblStatus.Text = ""
        bookName = txtSearchTitle.Text
        If txtSearchTitle.Text = "" Then
            lblStatus.Text = "Please enter a title."
        Else
            dgvBook.DataSource = mBooks.GetByBookTitle(bookName)
        End If


    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim rows As BookstoreDataSet.BooksRow

        Dim price As Decimal
        If dgvBook.SelectedRows.Count > 0 Then
            Dim bookid As Integer = CInt(dgvBook.SelectedRows(0).Cells(0).Value)
            rows = mBooks.FindByBookID(bookid)
            price = rows.Price
            If cart.bookOrdered.ContainsKey(bookid) Then
                lblStatus.Text = "This item is already in your cart."
            Else
                cart.bookOrdered.Add(bookid, New Order(bookid, rows.Title, rows.Author_Name, rows.Date_, rows.Price))
                lblStatus.Text = "Item " & bookid & " added successfully." 
            End If
        Else
            lblStatus.Text = "Please choose 1 item to add to cart."
        End If
    End Sub
End Class