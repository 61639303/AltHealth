Imports System.Data.SqlClient

Public Class AltHealthSupplementInfoAdd

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to add the new Supplement?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to cancel?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub AltHealthSupplementInfoAdd_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim connection As New SqlConnection("Server = GERRITRENTIA-PC\SQLEXPRESS; Database =  AltHealth; Integrated Security=True")
        Dim adapter As New SqlDataAdapter("SELECT * From tblSupplier_Info", connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        ComboBoxSupplierID.DataSource = table
        ComboBoxSupplierID.DisplayMember = "Supplier_ID"
        ComboBoxSupplierID.ValueMember = "Supplier_ID"
    End Sub
End Class