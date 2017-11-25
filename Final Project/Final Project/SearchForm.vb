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
        txtStatus.Text = ""
        Dim bookId As Integer
        If Integer.TryParse(txtSearchISBN.Text, bookId) Then
            dgvBook.DataSource = mBooks.GetByBookID(bookId)
        Else
            txtStatus.Text = "This is not a valid ISBN. Please enter again!"
            Return
            txtSearchISBN.Text = ""
        End If

    End Sub

    Private Sub btnSearchTitle_Click(sender As Object, e As EventArgs) Handles btnSearchTitle.Click
        Dim bookName As String = ""


    End Sub
End Class