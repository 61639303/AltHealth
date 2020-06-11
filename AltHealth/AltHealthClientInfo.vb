Imports System.Data.SqlClient
Public Class AltHealthClientInfo

    Dim connection As New SqlConnection("Server = GERRITRENTIA-PC\SQLEXPRESS; Database =  AltHealth; Integrated Security=True")

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to close the Client Information screen?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub AltHealthClientInfo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter("SELECT * From tblClientInfo", connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridViewClientInfo.DataSource = table
    End Sub

    Private Sub btnNewClient_Click(sender As System.Object, e As System.EventArgs) Handles btnNewClient.Click
        Dim form = New AltHealthClientInfoAdd()
        form.ShowDialog()
    End Sub


    Private Sub DataGridViewClientInfo_CellContentDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewClientInfo.CellContentDoubleClick
        Dim form As New AltHealthClientInfoDisplay()

        form.TextBoxClientID.Text = DataGridViewClientInfo.CurrentRow.Cells(0).Value.ToString()
        form.TextBoxName.Text = DataGridViewClientInfo.CurrentRow.Cells(1).Value.ToString()
        form.TextBoxSurname.Text = DataGridViewClientInfo.CurrentRow.Cells(2).Value.ToString()
        form.TextBoxAddress.Text = DataGridViewClientInfo.CurrentRow.Cells(3).Value.ToString()
        form.TextBoxCode.Text = DataGridViewClientInfo.CurrentRow.Cells(4).Value.ToString()
        form.TextBoxHome.Text = DataGridViewClientInfo.CurrentRow.Cells(5).Value.ToString()
        form.TextBoxWork.Text = DataGridViewClientInfo.CurrentRow.Cells(6).Value.ToString()
        form.TextBoxCell.Text = DataGridViewClientInfo.CurrentRow.Cells(7).Value.ToString()
        form.TextBoxEmail.Text = DataGridViewClientInfo.CurrentRow.Cells(8).Value.ToString()
        form.TextBoxReference.Text = DataGridViewClientInfo.CurrentRow.Cells(9).Value.ToString()

        form.ShowDialog()
    End Sub
End Class