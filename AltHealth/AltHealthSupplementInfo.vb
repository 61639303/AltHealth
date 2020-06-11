Imports System.Data.SqlClient

Public Class AltHealthSupplementInfo
    Dim connection As New SqlConnection("Server = GERRITRENTIA-PC\SQLEXPRESS; Database =  AltHealth; Integrated Security=True")
    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to close the Suppllement Information screen?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub


    Private Sub AltHealthSupplementInfo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter("SELECT * From tblSupplements", connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridViewSupplementInfo.DataSource = table
    End Sub

    Private Sub btnNewSupplement_Click(sender As System.Object, e As System.EventArgs) Handles btnNewSupplement.Click
        Dim form = New AltHealthSupplementInfoAdd()
        form.ShowDialog()
    End Sub

    Private Sub DataGridViewSupplementInfo_CellContentDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewSupplementInfo.CellContentDoubleClick
        Dim form As New AltHealthSupplementInfoDisplay()

        form.TextBoxSupplementID.Text = DataGridViewSupplementInfo.CurrentRow.Cells(0).Value.ToString()
        form.TextBoxDesc.Text = DataGridViewSupplementInfo.CurrentRow.Cells(1).Value.ToString()
        form.TextBoxCostEx.Text = DataGridViewSupplementInfo.CurrentRow.Cells(2).Value.ToString()
        form.TextBoxCostInc.Text = DataGridViewSupplementInfo.CurrentRow.Cells(3).Value.ToString()
        form.TextBoxMinLvl.Text = DataGridViewSupplementInfo.CurrentRow.Cells(4).Value.ToString()
        form.TextBoxCurLvl.Text = DataGridViewSupplementInfo.CurrentRow.Cells(5).Value.ToString()
        form.TextBoxNapppi.Text = DataGridViewSupplementInfo.CurrentRow.Cells(6).Value.ToString()
        form.TextBoxSupplierID.Text = DataGridViewSupplementInfo.CurrentRow.Cells(7).Value.ToString()
      

        form.ShowDialog()
    End Sub
End Class