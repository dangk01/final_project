Public Class SearchForm
    Private mBooks As New Books
    Private formLoading As Boolean = True


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
        If dgvBook.SelectedRows.Count > 0 Then
            Dim bookid As Integer = CInt(dgvBook.SelectedRows(0).Cells(0).Value)
            If Not Cart.bookIDs.Contains(bookid) Then
                rows = mBooks.FindByBookID(bookid)
                If rows.Quantity = 0 Then
                    lblStatus.Text = "This item is out of stock."
                    Return
                End If
                Cart.bookIDs.Add(bookid)
                lblStatus.Text = "Item " & bookid & " added successfully."
            Else
                lblStatus.Text = "This item is already in your cart."
            End If


        Else
            lblStatus.Text = "Please choose 1 item to add to cart."
        End If
    End Sub

    Private Sub btnSearchAuthor_Click(sender As Object, e As EventArgs) Handles btnSearchAuthor.Click
        Dim bookAUthor As String
        lblStatus.Text = ""
        bookAUthor = txtSearchAuthor.Text
        If txtSearchAuthor.Text = "" Then
            lblStatus.Text = "Please enter a name."
        Else
            dgvBook.DataSource = mBooks.GetByBookAuthor(bookAUthor)

        End If

    End Sub
End Class