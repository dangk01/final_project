Public Class Bonus
    Private adapter As New BookstoreDataSetTableAdapters.BonusTableAdapter

    Public ReadOnly Property items() As DataTable
        Get
            Return adapter.GetData()

        End Get
    End Property

    Public Function FindByBonusID(ByVal id As Integer) As BookstoreDataSet.BonusRow
        Dim table As BookstoreDataSet.BonusDataTable
        table = adapter.GetData()
        Return table.FindByBonusID(id)
    End Function
End Class
