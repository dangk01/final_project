Public Class WelcomeForm
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        txtID.Text = ""
        MainForm.ShowDialog()


    End Sub
End Class
