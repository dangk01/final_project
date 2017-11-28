Public Class Books
    Private adapter As New BookstoreDataSetTableAdapters.BooksTableAdapter


    Public ReadOnly Property Items As DataTable
        Get
            Dim table As DataTable = adapter.GetData()
            table.DefaultView.Sort = "Title"
            Return table

        End Get
    End Property

    Public Function GetByBookID(ByVal bookID As Integer) As DataTable
        Dim table As DataTable = adapter.GetData()
        table.DefaultView.RowFilter = "BookID  = " & bookID

        Return table

    End Function

    Public Function GetByBookTitle(ByVal title As String) As DataTable
        Dim table As DataTable = adapter.GetDataByTitle(title)
        Return table

    End Function

    Public Function GetByBookAuthor(ByVal author As String) As DataTable
        Dim table As DataTable = adapter.GetDataByName(author)
        Return table

    End Function

    Public Function FindByBookID(ByVal bookid As Integer) As BookstoreDataSet.BooksRow
        Dim table As BookstoreDataSet.BooksDataTable
        table = adapter.GetData()
        Return table.FindByBookID(bookid)
    End Function


End Class
