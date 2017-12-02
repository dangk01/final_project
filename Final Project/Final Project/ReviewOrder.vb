Public Class ReviewOrder
    Private adapter As New BookstoreDataSetTableAdapters.OrderLineTableAdapter
    Private adapter1 As New BookstoreDataSetTableAdapters.OrdersTableAdapter

    Public Function getMaxID() As Integer
        Return CInt(adapter.GetMaxID)
    End Function

    Public ReadOnly Property items() As DataTable
        Get
            Return adapter.GetNewOrderInfo(getMaxID())
        End Get
    End Property

    Public ReadOnly Property items1() As DataTable
        Get
            Return adapter1.GetDataByCustID(Customers.custID)
        End Get
    End Property
    Public Function FindByOrderID(ByVal id As Integer) As BookstoreDataSet.OrdersRow
        Dim table As BookstoreDataSet.OrdersDataTable
        table = adapter1.GetData()
        Return table.FindByOrderID(id)
    End Function

End Class
