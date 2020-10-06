Imports System.Data.SqlClient

Public Class AltHealthSupplementInfoDisplay
    Dim connection As New SqlConnection("Server = GERRITRENTIA-PC\SQLEXPRESS; Database =  AltHealth; Integrated Security=True")
    'Constant declared for VAT
    Const VAT = 0.15
    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        'Closes the display screen
        Me.Close()
    End Sub

    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        btnSave.Enabled = True
        btnSave.Visible = True
        btnEdit.Enabled = False
        TextBoxCurLvl.Enabled = True
        TextBoxDesc.Enabled = True
        TextBoxCostEx.Enabled = True
        TextBoxMinLvl.Enabled = True
        TextBoxNapppi.Enabled = True

    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to edit the Supllement info?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        'If yes is clicked, then the textbox and dropdown values are written to the DB, If no is clicked, then the Add screen is still displayed
        If result = DialogResult.Yes Then
            'Sql Command to update row into DB

            Dim command As New SqlCommand("Update tblSupplements set Supplement_id = @Supplement_id, Description = @Description, Cost_excl = @Cost_excl, Cost_incl = @Cost_incl, Min_levels = @Min_levels, Current_stock_levels = @Current_stock_levels, Nappi_code = @Nappi_code, Supplier_ID = @Supplier_ID where (Supplement_id = @Supplement_id)", connection)

            Dim CostIncl As Decimal = (Convert.ToDecimal(TextBoxCostEx.Text) * VAT) + Convert.ToDecimal(TextBoxCostEx.Text)
          
            command.Parameters.Add("@Supplement_id", SqlDbType.VarChar).Value = TextBoxSupplementID.Text
            command.Parameters.Add("@Description", SqlDbType.VarChar).Value = TextBoxDesc.Text
            command.Parameters.Add("@Cost_excl", SqlDbType.Decimal).Value = Convert.ToDecimal(TextBoxCostEx.Text)
            command.Parameters.Add("@Cost_incl", SqlDbType.Decimal).Value = Convert.ToDecimal(CostIncl)
            command.Parameters.Add("@Min_levels", SqlDbType.Int).Value = Convert.ToInt32(TextBoxMinLvl.Text)
            command.Parameters.Add("@Current_stock_levels", SqlDbType.Int).Value = Convert.ToInt32(TextBoxCurLvl.Text)
            command.Parameters.Add("@Nappi_code", SqlDbType.VarChar).Value = TextBoxNapppi.Text
            command.Parameters.Add("@Supplier_ID", SqlDbType.VarChar).Value = TextBoxSupplierID.Text

            'Connection is opened up to DB
            connection.Open()

            'SQL Query is executed
            command.ExecuteNonQuery()

            'Confirmation message to inform user that the record has been written to the DB
            MessageBox.Show("Supplement Id " & TextBoxSupplementID.Text & " has been edited in the  Supplement Database.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Connection is closed
            connection.Close()

            'Call Function to Refresh Data on previous screen

            AltHealthSupplementInfo.Refresh_Supplements()
            Dim form As New AltHealthSupplementInfo
            Me.Close()
            form.ShowDialog()
        End If
    End Sub

End Class