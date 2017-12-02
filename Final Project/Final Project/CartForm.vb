Public Class CartForm
    Public Property BookID As New ArrayList
    Public Property orderedBooks As New SortedDictionary(Of Integer, Order)
    Private mBooks As New Books
    Private mOrders As Order
    Private mCart As New Cart
    Dim search As New SearchForm
    Dim subTotal As Decimal
    Dim rate As Decimal = Cart.discountRate
    Dim shippingFee As Decimal = 0
    Dim total As Decimal = subTotal
    Dim sId As Integer
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
        BookID.Clear()
        lstCart.Items.Clear()
        orderedBooks.Clear()
        subTotal = 0
    End Sub

    Private Sub btnPlace_Click(sender As Object, e As EventArgs) Handles btnPlace.Click
        'ExtraBonusForm.ShowDialog()
        'ReviewOrderForm.ShowDialog()
        Dim d As DateTime = DateTime.Today
        Dim success As Boolean = True

        If radExpress.Checked = False And radNormal.Checked = False And radSaving.Checked = False Then
            MessageBox.Show("Please choose a shipping type!")
        Else
            If Not mCart.Insert(Customers.custID, d, sId, total, Promotions.promotionID) Then
                success = False
            End If
            For Each i In Cart.bookIDs
                If Not mCart.Insert(i) Then
                    success = False
                End If
                If Not mCart.Update(i) Then
                    success = False
                End If
            Next

            If success = True Then
                MessageBox.Show("New order is placed successfully.")

                If subTotal >= 60 Then
                    ExtraBonusForm.ShowDialog()
                Else
                    Cart.bookIDs.Clear()
                    orderedBooks.Clear()
                    lstCart.Items.Clear()

                    ReviewOrderForm.ShowDialog()
                    Me.Close()
                    SearchForm.Close()

                End If

            Else
                MessageBox.Show("Cannot add order. " & Cart.lastError)
            End If

        End If



    End Sub

    Private Sub CartForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rows As BookstoreDataSet.BooksRow

        lblPromotion.Text = Cart.discountName
        For Each i In Cart.bookIDs
            rows = mBooks.FindByBookID(i)
            orderedBooks.Add(i, New Order(i, rows.Title, rows.Price))

        Next
        For Each i In orderedBooks
            lstCart.Items.Add(i.Value.bookTitle)
            subTotal += i.Value.bookPrice
        Next
        lblSubtotal.Text = subTotal
        lblDiscountAmount.Text = "-" & (subTotal * Cart.discountRate).ToString("c")


    End Sub



    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim key1 As Integer
        If lstCart.SelectedIndex = -1 Then
            MessageBox.Show("Please choose 1 item to delete!")
        Else

            For Each i In orderedBooks
                If i.Value.bookTitle = lstCart.SelectedItem Then
                    subTotal -= i.Value.bookPrice
                    key1 = i.Key
                End If
            Next
            Cart.bookIDs.Remove(key1)
            lstCart.Items.Remove(lstCart.SelectedItem)
            lblSubtotal.Text = subTotal.ToString("c")
            total = subTotal - subTotal * Cart.discountRate + shippingFee
            lblDiscountAmount.Text = "-" & (subTotal * Cart.discountRate).ToString("c")
            If radExpress.Checked Or radNormal.Checked Or radSaving.Checked Then
                lblTotal.Text = total.ToString("c")
            End If
        End If


    End Sub




    Private Sub btnChoose_Click(sender As Object, e As EventArgs) Handles btnChoose.Click
        If radSaving.Checked Then
            shippingFee = 5.0
            sId = 1
            lblTotal.Visible = True
        ElseIf radNormal.Checked Then
            shippingFee = 10.0
            sId = 2
            lblTotal.Visible = True
        ElseIf radExpress.Checked Then
            shippingFee = 20.0
            sId = 3
            lblTotal.Visible = True
        Else
            MessageBox.Show("Please choose a shipping type!")
        End If

        total = subTotal - subTotal * Cart.discountRate + shippingFee
        lblTotal.Text = total.ToString("c")
    End Sub
End Class