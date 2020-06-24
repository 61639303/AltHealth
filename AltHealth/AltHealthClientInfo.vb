Imports System.Data.SqlClient
Public Class AltHealthClientInfo

    'Variable to Connect to Database
    Dim connection As New SqlConnection("Server = GERRITRENTIA-PC\SQLEXPRESS; Database =  AltHealth; Integrated Security=True")

    Private Sub btnNewClient_Click(sender As System.Object, e As System.EventArgs) Handles btnNewClient.Click
        'Temporarily Disables the Client Info Screen and Opens the Client Info Add Screen

        Dim form = New AltHealthClientInfoAdd()
        form.ShowDialog()

    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to close the Client Information screen?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'If user Clicks on Yes, then the Client Info Screen is closed. If the user clicks on No, then the Client Info Screen is still visible for the user
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub AltHealthClientInfo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Calls Function to Refresh Data in Data Grid View
        Refresh_ClientInfo()
    End Sub

    Private Sub DataGridViewClientInfo_CellContentDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewClientInfo.CellContentDoubleClick
        'Temporarily Disables the Client Info Screen and Opens the Client Info Display Screen
        Dim form As New AltHealthClientInfoDisplay()

        'Fills the Textboxes in the Form with the values of the selected Row from the Datadrid
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


    Public Sub Refresh_ClientInfo()

        'Function that Fills Data in the Data Grid View
        Dim adapter As New SqlDataAdapter("SELECT * From tblClientInfo", connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridViewClientInfo.DataSource = table
        DataGridViewClientInfo.Refresh()


    End Sub


End Class