Public Class ReviewOrderForm
    Private mCart As New Cart
    Private mReview As New ReviewOrder
    Private mShipping As New Shipping
    Private mBonus As New Bonus

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        SearchForm.Close()
        CartForm.Close()

    End Sub

    Private Sub ReviewOrderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rows As BookstoreDataSet.OrdersRow
        Dim rows1 As BookstoreDataSet.ShippingsRow
        Dim rows2 As BookstoreDataSet.BonusRow
        rows = mReview.FindByOrderID(mCart.getMaxID)
        rows1 = mShipping.FindByShippingID(rows.ShippingID)
        rows2 = mBonus.FindByBonusID(rows.BonusID)

        lblExtraBonus.Text = rows2.Description
        lblShipping.Text = rows1.Shipping_Type
        dgvNewOrder.DataSource = mReview.items

    End Sub
End Class