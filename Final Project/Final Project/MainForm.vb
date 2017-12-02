Public Class MainForm
    Dim mCust As New Customers
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Customers.custID = 0
        Me.Close()


    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        SearchForm.ShowDialog()

    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        OrderHistoryForm.ShowDialog()

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rows As BookstoreDataSet.CustomersRow
        If Customers.custID <> 0 Then
            rows = mCust.FindByCustID(Customers.custID)
            lblName.Text = rows.Name
        End If



    End Sub
End Class