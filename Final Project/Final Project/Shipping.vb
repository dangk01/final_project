Public Class Shipping
    Private adapter As New BookstoreDataSetTableAdapters.ShippingsTableAdapter

    Public Function FindByShippingID(ByVal id As Integer) As BookstoreDataSet.ShippingsRow
        Dim table As BookstoreDataSet.ShippingsDataTable
        table = adapter.GetData()
        Return table.FindByShippingID(id)
    End Function
End Class
