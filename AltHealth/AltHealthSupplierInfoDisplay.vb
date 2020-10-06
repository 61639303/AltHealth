Imports System.Data.SqlClient

Public Class AltHealthSupplierInfoDisplay
    'Variable to Connect to Database
    Dim connection As New SqlConnection("Server = GERRITRENTIA-PC\SQLEXPRESS; Database =  AltHealth; Integrated Security=True")
    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        'Closes the display screen
        Me.Close()
    End Sub

    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        btnSave.Enabled = True
        btnSave.Visible = True
        btnEdit.Enabled = False


        TextBoxContact.Enabled = True
        TextBoxTel.Enabled = True
        TextBoxEmail.Enabled = True
        TextBoxCode.Enabled = True
        TextBoxBank.Enabled = True
        TextBoxCode.Enabled = True
        TextBoxBankNr.Enabled = True
        TextBoxType.Enabled = True


    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to edit the Supplier info?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        'If yes is clicked, then the textbox and dropdown values are written to the DB, If no is clicked, then the Add screen is still displayed
        If result = DialogResult.Yes Then
            'Sql Command to update row into DB

            Dim command As New SqlCommand("Update tblSupplier_Info set Supplier_ID = @Supplier_ID, Contact_Person = @Contact_Person, Supplier_Tel = @Supplier_Tel, Supplier_Email = @Supplier_Email, Bank = @Bank, Bank_code = @Bank_code, Supplier_BankNum = @Supplier_BankNum, Supplier_Type_Bank_Account = @Supplier_Type_Bank_Account where (Supplier_ID = @Supplier_ID)", connection)


            'varible to store supplierphone
            Dim supplierphone As String
            'If phone nr is blank, then mask is ignored and blank value is written in
            If TextBoxTel.Text = "(   )-(   )-(   )" Then
                supplierphone = ""
            Else
                supplierphone = TextBoxTel.Text
            End If

            command.Parameters.Add("@Supplier_ID", SqlDbType.VarChar).Value = TextBoxSupplierID.Text
            command.Parameters.Add("@Contact_Person", SqlDbType.VarChar).Value = TextBoxContact.Text
            command.Parameters.Add("@Supplier_Tel", SqlDbType.VarChar).Value = supplierphone
            command.Parameters.Add("@Supplier_Email", SqlDbType.VarChar).Value = TextBoxEmail.Text
            command.Parameters.Add("@Bank", SqlDbType.VarChar).Value = TextBoxBank.Text
            command.Parameters.Add("@Bank_code", SqlDbType.VarChar).Value = TextBoxCode.Text
            command.Parameters.Add("@Supplier_BankNum", SqlDbType.VarChar).Value = TextBoxBankNr.Text
            command.Parameters.Add("@Supplier_Type_Bank_Account", SqlDbType.VarChar).Value = TextBoxType.Text

            'Connection is opened up to DB
            connection.Open()

            'SQL Query is executed
            command.ExecuteNonQuery()

            'Confirmation message to inform user that the record has been written to the DB
            MessageBox.Show("Supplier ID " & TextBoxSupplierID.Text & " has been edited in the  Supplier Database.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Connection is closed
            connection.Close()

            'Call Function to Refresh Data on previous screen
            AltHealthSupplierInfo.Refresh_SupplierInfo()

            Dim form = New AltHealthSupplierInfo()
            Me.Close()
            form.ShowDialog()
        End If
    End Sub
End Class