Public Class CartForm
    Public Property BookID As Integer
    Public bookOrdered As New Dictionary(Of Integer, Order)
    Dim total As Decimal

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()

    End Sub

    Private Sub btnPlace_Click(sender As Object, e As EventArgs) Handles btnPlace.Click
        'ExtraBonusForm.ShowDialog()
        'ReviewOrderForm.ShowDialog()
        Me.Close()
        SearchForm.Close()
    End Sub

    Private Sub CartForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each b In bookOrdered
            lstCart.Items.Add(b.Value.ToString)
            total += b.Value.bookPrice
        Next
        lblSubtotal.Text = total
    End Sub
End Class