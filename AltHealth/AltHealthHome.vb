Public Class AltHealthHome

    Private Sub btnClientInfo_Click(sender As System.Object, e As System.EventArgs) Handles btnClientInfo.Click
        'Temporarily Disables the Home Screen and Opens the Client Info Screen
        Dim form = New AltHealthClientInfo()
        form.ShowDialog()
    End Sub

    Private Sub btnSupplierInfo_Click(sender As System.Object, e As System.EventArgs) Handles btnSupplierInfo.Click
        'Temporarily Disables the Home Screen and Opens the Supplier Info Screen
        Dim form = New AltHealthSupplierInfo()
        form.ShowDialog()
    End Sub

    Private Sub btnSupplementInfo_Click(sender As System.Object, e As System.EventArgs) Handles btnSupplementInfo.Click
        'Temporarily Disables the Home Screen and Opens the Supplements Info Screen
        Dim form = New AltHealthSupplementInfo()
        form.ShowDialog()
    End Sub

    Private Sub btnReporting_Click(sender As System.Object, e As System.EventArgs) Handles btnReporting.Click
        'Temporarily Disables the Home Screen and Opens the Reporting Info Screen
        Dim form = New AltHealthReporting()
        form.ShowDialog()
    End Sub

    Private Sub btnInvoices_Click(sender As System.Object, e As System.EventArgs) Handles btnInvoices.Click
        'Temporarily Disables the Home Screen and Opens the Invoices Info Screen
        Dim form = New AltHealthInvoices()
        form.ShowDialog()
    End Sub

    Private Sub btnCart_Click(sender As System.Object, e As System.EventArgs) Handles btnCart.Click
        'Temporarily Disables the Home Screen and Opens the Shopping Cart Info Screen
        Dim form = New AltHealthShoppingCart()
        form.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        'Exits the Whole Appliction
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit the AltHealth Application?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
        'If user Clicks on Yes, then the application is closed. If the user clicks on No, then the Home Screen is still visible for the user
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnSystemAdmin_Click(sender As System.Object, e As System.EventArgs) Handles btnSystemAdmin.Click
        'Temporarily Disables the Home Screen and Opens the Shopping Cart Info Screen
        Dim form = New AltHealthSystemAdmin()
        form.ShowDialog()
    End Sub
End Class
