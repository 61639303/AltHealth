Imports System.Data.SqlClient

Public Class AltHealthInvoices
    'Constant declared for VAT
    Const VAT = 0.15
    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to close the Invoices screen?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub AltHealthInvoices_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Clear all textbox when form loads
        lblClientID.Text = ""
        lblInvDate.Text = ""
        lblInvPaidDate.Text = ""
        lblClientName.Text = ""
        lblClientAddress.Text = ""
        lblClientHome.Text = ""
        lblClientWork.Text = ""
        lblClientCell.Text = ""
        lblClientEmail.Text = ""
        txtBoxInvoiceNumber.Clear()
        txtBoxInvoiceNumber.Focus()
        txtBoxInvoiceNumber.Select(3, 1)
    End Sub

    Private Sub Populate_Invoice(ByVal Inv_nr As String)

        Dim connection As New SqlConnection("Server = GERRITRENTIA-PC\SQLEXPRESS; Database =  AltHealth; Integrated Security=True")
        Dim adapter2 As New SqlDataAdapter("SELECT * From tblInv_info where Inv_Num = '" & Inv_nr & "'", connection)
        Try
            Dim table2 As New DataTable()

            adapter2.Fill(table2)

            GroupBoxInv.Text = Inv_nr
            lblInvDate.Text = table2(0)(1)
            If table2(0)(2) = "Y" Then
                lblInvPaidDate.Text = table2(0)(3)
            Else : lblInvPaidDate.Text = ""
            End If

            lblClientID.Text = table2(0)(5)

            Dim adapter3 As New SqlDataAdapter("SELECT * From tblClientInfo where Client_id = " & lblClientID.Text, connection)
            Dim table3 As New DataTable()
            adapter3.Fill(table3)
            lblClientName.Text = table3(0)(1) & "" & table3(0)(2)
            lblClientAddress.Text = table3(0)(3) & " " & table3(0)(4)
            lblClientHome.Text = table3(0)(5)
            lblClientWork.Text = table3(0)(6)
            lblClientCell.Text = table3(0)(7)
            lblClientEmail.Text = table3(0)(8)

            Dim adapter As New SqlDataAdapter("select Supplement_id as Item, Item_price as Price, Item_quantity as QTY, (Item_price * Item_quantity) as Total from tblInv_Items where Inv_Num = '" & Inv_nr & "'", connection)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridViewInvoiceItems.DataSource = table

            Dim totalExc As Decimal

            For Each row As DataGridViewRow In DataGridViewInvoiceItems.Rows
                If row.Cells(3).Value > 0 Then
                    totalExc += row.Cells(3).Value
                End If
            Next

            '  Dim totalex As Decimal
            Dim totalVat As Decimal
            Dim totalInc As Decimal


            Dim symbol As String = "R "
            lblTotalExcl.Text = String.Format("{0:" + symbol + "#,##0.00}", totalExc)
            totalVat = lblTotalExcl.Text * VAT
            lblTotalVat.Text = String.Format("{0:" + symbol + "#,##0.00}", totalVat)
            totalInc = totalExc + totalVat
            lblTotalIncl.Text = String.Format("{0:" + symbol + "#,##0.00}", totalInc)



        Catch ex As Exception
            MessageBox.Show("Invoice Number does not Exist. Please Enter the Correct Invoice Number.", "Invoice Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBoxInvoiceNumber.Select(3, 5)
            txtBoxInvoiceNumber.Focus()
        End Try
    End Sub



    Private Sub txtBoxInvoiceNumber_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtBoxInvoiceNumber.KeyDown
        'When enter is pressed, invoice number is searched  and function to populate values are called
        If e.KeyCode = Keys.Enter Then

            Dim Inv_Num As String
            Inv_Num = txtBoxInvoiceNumber.Text

            Me.Populate_Invoice(Inv_Num)
            txtBoxInvoiceNumber.Clear()
            txtBoxInvoiceNumber.Focus()
            txtBoxInvoiceNumber.Select(3, 1)
        End If
    End Sub


End Class
