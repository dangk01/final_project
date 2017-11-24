Public Class WelcomeForm
    Dim mCustomers As New Customers

    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs)
        txtID.Text = ""
        MainForm.ShowDialog()


    End Sub

    Private Sub WelcomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BookstoreDataSet.Promotions1' table. You can move, or remove it, as needed.
        Me.Promotions1TableAdapter.Fill(Me.BookstoreDataSet.Promotions1)
        'TODO: This line of code loads data into the 'BookstoreDataSet.Books1' table. You can move, or remove it, as needed.
        Me.Books1TableAdapter.Fill(Me.BookstoreDataSet.Books1)

    End Sub

    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnLog_Click_1(sender As Object, e As EventArgs) Handles btnLog.Click

    End Sub
End Class
