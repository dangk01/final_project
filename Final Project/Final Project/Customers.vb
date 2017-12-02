Public Class Customers
    Private adapter As New BookstoreDataSetTableAdapters.CustomersTableAdapter
    Public Shared Property custID As Integer = 0

    Public Function checkID(ByVal id As Integer) As Boolean
        Dim idExists As Boolean = True
        Dim count As Integer = adapter.CheckID(id)
        If count <> 1 Then
            idExists = False
        End If
        Return idExists
    End Function

    Public Function FindByCustID(ByVal id As Integer) As BookstoreDataSet.CustomersRow
        Dim table As BookstoreDataSet.CustomersDataTable
        table = adapter.GetData()
        Return table.FindByCustID(id)
    End Function
End Class
