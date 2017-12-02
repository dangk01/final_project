Public Class Promotions
    Private adapter As New BookstoreDataSetTableAdapters.PromotionsTableAdapter
    Public Shared Property promotionID As Integer
    Public ReadOnly Property Items As DataTable
        Get
            Dim table As DataTable = adapter.GetData()
            Return table

        End Get
    End Property

    Public Function FindByPromotionID(ByVal id As Integer) As BookstoreDataSet.PromotionsRow
        Dim table As BookstoreDataSet.PromotionsDataTable
        table = adapter.GetData()
        Return table.FindByPromotionID(id)
    End Function
End Class
