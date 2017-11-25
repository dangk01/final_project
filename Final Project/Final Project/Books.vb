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



End Class
