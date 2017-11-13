Public Class CartForm
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()

    End Sub

    Private Sub btnPlace_Click(sender As Object, e As EventArgs) Handles btnPlace.Click
        'ExtraBonusForm.ShowDialog()
        'ReviewOrderForm.ShowDialog()
        Me.Close()
        SearchForm.Close()
    End Sub
End Class