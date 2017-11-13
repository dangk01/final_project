Public Class ExtraBonusForm


    Private Sub btnChoose_Click(sender As Object, e As EventArgs) Handles btnChoose.Click
        ReviewOrderForm.ShowDialog()
        Me.Close()
    End Sub
End Class