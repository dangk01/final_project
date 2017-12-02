Public Class WelcomeForm
    Dim mCustomers As New Customers
    Dim mPromotion As New Promotions
    Public customerId As Integer

    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub



    Private Sub WelcomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BookstoreDataSet.Promotions1' table. You can move, or remove it, as needed.
        '  Me.Promotions1TableAdapter.Fill(Me.BookstoreDataSet.Promotions1)
        'TODO: This line of code loads data into the 'BookstoreDataSet.Books1' table. You can move, or remove it, as needed.
        Me.Books1TableAdapter.Fill(Me.BookstoreDataSet.Books1)

        lstPromotion.DataSource = mPromotion.Items()
        lstPromotion.DisplayMember = "Description"
        lstPromotion.ValueMember = "PromotionID"
        lstPromotion.SelectedIndex = 0

        Dim rows As BookstoreDataSet.PromotionsRow
        rows = mPromotion.FindByPromotionID(lstPromotion.SelectedValue)
        lblStart.Text = rows.StartDate
        lblEnd.Text = rows.EndDate
        lblRate.Text = rows.DiscountRate
        Cart.discountName = rows.Description
        Cart.discountRate = rows.DiscountRate
        Promotions.promotionID = rows.PromotionID
    End Sub

    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub btnLog_Click_1(sender As Object, e As EventArgs) Handles btnLog.Click
        Dim id As Integer
        If Integer.TryParse(txtID.Text, id) Then
            If mCustomers.checkID(id) = True Then
                Customers.custID = id
                MainForm.ShowDialog()

            Else
                errProvider.SetError(txtID, "This app is exclusive for the customers for our store only. Sorry for this inconvenience.")
            End If
        Else
            errProvider.SetError(txtID, "This is not a vaild input. Please enter again.")
        End If

        txtID.Text = ""
    End Sub
End Class
