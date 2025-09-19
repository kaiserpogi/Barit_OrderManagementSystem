Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Try
            Dim customerName As String = txtCustomerName.Text
            Dim beverage As String = cmbBeverage.SelectedItem.ToString()
            Dim quantity As Integer = CInt(numQuantity.Value)
            Dim applyDiscount As Boolean = chkDiscount.Checked
            Dim price As Decimal = 0
            Select Case beverage
                Case "Espresso"
                    price = 120
                Case "Latte"
                    price = 150
                Case "Cappuccino"
                    price = 160
                Case "Americano"
                    price = 130
                Case "Mocha"
                    price = 170
            End Select
            Dim subtotal As Decimal = price * quantity
            Dim discountAmount As Decimal = 0
            If applyDiscount Then
                discountAmount = subtotal * 0.1
            End If
            Dim finalTotal As Decimal = subtotal - discountAmount

            lblSubtotal.Text = subtotal.ToString()("N2") & "PHP"
            lblDiscount.Text = discountAmount.ToString()("N2") & "PHP"
            lblFinalTotalValue.Text = finalTotal.ToString()("N2") & "PHP"
        Catch ex As Exception
            MessageBox.Show("Please check your inputs and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click
        If String.IsNullOrEmpty(txtCustomerName.Text) Then
            MessageBox.Show("Please enter customer name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If cmbBeverage.SelectedIndex = -1 Then
            MessageBox.Show("Please select a beverage", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        MessageBox.Show($"Order for {txtCustomerName.Text} placed successfully! Total: {lblFinalTotalValue.Text}",
                        "Order Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
