Imports System.Data.SqlClient

Public Class AltHealthClientInfoDisplay
    Dim connection As New SqlConnection("Server = GERRITRENTIA-PC\SQLEXPRESS; Database =  AltHealth; Integrated Security=True")

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        'Closes the display screen
        Me.Close()
    End Sub


    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        btnSave.Enabled = True
        btnSave.Visible = True
        btnEdit.Enabled = False


        TextBoxName.Enabled = True
        TextBoxSurname.Enabled = True
        TextBoxAddress.Enabled = True
        TextBoxCode.Enabled = True
        TextBoxHome.Enabled = True
        TextBoxWork.Enabled = True
        TextBoxCell.Enabled = True
        TextBoxEmail.Enabled = True

    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to edit the Client info?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        'If yes is clicked, then the textbox and dropdown values are written to the DB, If no is clicked, then the Add screen is still displayed
        If result = DialogResult.Yes Then
            'Sql Command to update row into DB

            Dim command As New SqlCommand("Update tblClientInfo set Client_id = @Client_id, C_name = @C_name, C_surname = @C_surname, Address = @Address, Code = @Code, C_Tel_H = @C_Tel_H, C_Tel_W = @C_Tel_W, C_Tel_C = @C_Tel_C, C_Email = @C_Email, Reference_ID = @Reference_ID where (Client_id = @Client_id)", connection)


            'varible to store homephone
            Dim homephone As String
            'If phone nr is blank, then mask is ignored and blank value is written in
            If TextBoxHome.Text = "(   )-(   )-(   )" Then
                homephone = ""
            Else
                homephone = TextBoxHome.Text
            End If

            'varible to store workphone
            Dim workphone As String
            'If phone nr is blank, then mask is ignored and blank value is written in
            If TextBoxWork.Text = "(   )-(   )-(   )" Then
                workphone = ""
            Else
                workphone = TextBoxHome.Text
            End If

            'varible to store cellphone
            Dim cellphone As String
            'If phone nr is blank, then mask is ignored and blank value is written in
            If TextBoxCell.Text = "(   )-(   )-(   )" Then
                cellphone = ""
            Else
                cellphone = TextBoxHome.Text
            End If


            command.Parameters.Add("@Client_id", SqlDbType.VarChar).Value = TextBoxClientID.Text
            command.Parameters.Add("@C_name", SqlDbType.VarChar).Value = TextBoxName.Text
            command.Parameters.Add("@C_surname", SqlDbType.VarChar).Value = TextBoxSurname.Text
            command.Parameters.Add("@Address", SqlDbType.VarChar).Value = TextBoxAddress.Text
            command.Parameters.Add("@Code", SqlDbType.VarChar).Value = TextBoxCode.Text
            command.Parameters.Add("@C_Email", SqlDbType.VarChar).Value = TextBoxEmail.Text
            command.Parameters.Add("@Reference_ID", SqlDbType.VarChar).Value = TextBoxReference.Text
            command.Parameters.Add("@C_Tel_H", SqlDbType.VarChar).Value = homephone
            command.Parameters.Add("@C_Tel_W", SqlDbType.VarChar).Value = workphone
            command.Parameters.Add("@C_Tel_C", SqlDbType.VarChar).Value = cellphone

            'Connection is opened up to DB
            connection.Open()

            'SQL Query is executed
            command.ExecuteNonQuery()

            'Confirmation message to inform user that the record has been written to the DB
            MessageBox.Show("Client ID " & TextBoxClientID.Text & " has been edited in the  Client Database.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Connection is closed
            connection.Close()

            'Call Function to Refresh Data on previous screen
            AltHealthClientInfo.Refresh_ClientInfo()

            Dim form = New AltHealthClientInfo()
            Me.Close()
            form.ShowDialog()
        End If
    End Sub
End Class