Imports System.Data.SqlClient

Public Class AltHealthSupplierInfo

    'Variable to Connect to Database
    Dim connection As New SqlConnection("Server = GERRITRENTIA-PC\SQLEXPRESS; Database =  AltHealth; Integrated Security=True")


    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to close the Supplier Information screen?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'If user Clicks on Yes, then the Supplier Info Screen is closed. If the user clicks on No, then the Supplier Info Screen is still visible for the user
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub AltHealthSupplierInfo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'Calls Function to Refresh Data in Data Grid View
        Refresh_SupplierInfo()
    End Sub

    Private Sub btnNewSupplier_Click(sender As System.Object, e As System.EventArgs) Handles btnNewSupplier.Click

        'Temporarily Disables the Supplier Info Screen and Opens the Supplier Info Add Screen
        Dim form = New AltHealthSupplierInfoAdd()
        form.ShowDialog()

    End Sub

    Private Sub DataGridViewSupplierInfo_CellContentDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewSupplierInfo.CellContentDoubleClick

        'Temporarily Disables the Supplier Info Screen and Opens the Supplier Info Display Screen
        Dim form As New AltHealthSupplierInfoDisplay()

        'Fills the Textboxes in the Form with the values of the selected Row from the Datadrid
        form.TextBoxSupplierID.Text = DataGridViewSupplierInfo.CurrentRow.Cells(0).Value.ToString()
        form.TextBoxContact.Text = DataGridViewSupplierInfo.CurrentRow.Cells(1).Value.ToString()
        form.TextBoxTel.Text = DataGridViewSupplierInfo.CurrentRow.Cells(2).Value.ToString()
        form.TextBoxEmail.Text = DataGridViewSupplierInfo.CurrentRow.Cells(3).Value.ToString()
        form.TextBoxBank.Text = DataGridViewSupplierInfo.CurrentRow.Cells(4).Value.ToString()
        form.TextBoxCode.Text = DataGridViewSupplierInfo.CurrentRow.Cells(5).Value.ToString()
        form.TextBoxBankNr.Text = DataGridViewSupplierInfo.CurrentRow.Cells(6).Value.ToString()
        form.TextBoxType.Text = DataGridViewSupplierInfo.CurrentRow.Cells(7).Value.ToString()
        form.ShowDialog()

    End Sub

    Public Sub Refresh_SupplierInfo()

        'Function that Fills Data in the Data Grid View
        Dim adapter As New SqlDataAdapter("SELECT * From tblSupplier_Info", connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridViewSupplierInfo.DataSource = table
        DataGridViewSupplierInfo.Refresh()


    End Sub
End Class