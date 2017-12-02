Imports System.ComponentModel

Public Class ExtraBonusForm
    Dim mBonus As New Bonus
    Dim mCart As New Cart
    Private Sub btnChoose_Click(sender As Object, e As EventArgs) Handles btnChoose.Click
        Dim cartF As New CartForm
        If mCart.UpdateOrder(cboExtraBonus.SelectedValue) Then
            Cart.bookIDs.Clear()
            cartF.lstCart.Items.Clear()
            cartF.orderedBooks.Clear()
            ReviewOrderForm.ShowDialog()
            Me.Close()
        End If
    End Sub

    Private Sub ExtraBonusForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

    End Sub

    Private Sub ExtraBonusForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboExtraBonus.DataSource = mBonus.items
        cboExtraBonus.DisplayMember = "Description"
        cboExtraBonus.ValueMember = "BonusID"
        cboExtraBonus.SelectedIndex = 0
    End Sub
End Class