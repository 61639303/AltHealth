Imports System.Data.SqlClient

Public Class AltHealthSupplementInfoAdd

    'Variable to Connect to Database
    Dim connection As New SqlConnection("Server = GERRITRENTIA-PC\SQLEXPRESS; Database =  AltHealth; Integrated Security=True")

    'Constant declared for VAT
    Const VAT = 0.15


    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click

        'Check if the mandatory fields are blank when the OK Button is pressed
        If TextBoxSupplementID.Text = "" Then
            MessageBox.Show("Supplement ID is a Mandatory Field, please enter and try again", "Mandatory Fields not filled in", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'If all Mandatory fields are filled in, confirmation is asked from the user
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to add the new Supplement?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                'If yes is clicked, then the textbox and dropdown values are written to the DB, If no is clicked, then the Add screen is still displayed
                Dim CostIncl As Decimal = (Convert.ToDecimal(TextBoxCostEx.Text) * VAT) + Convert.ToDecimal(TextBoxCostEx.Text)
                Dim command As New SqlCommand("Insert into tblSupplements (Supplement_id, Description, Cost_excl, Cost_incl, Min_levels, Current_stock_levels, Nappi_code, Supplier_ID) values (@Supplement_id,@Description,@Cost_excl,@Cost_incl,@Min_levels,@Current_stock_levels,@Nappi_code,@Supplier_ID)", connection)

                command.Parameters.Add("@Supplement_id", SqlDbType.VarChar).Value = TextBoxSupplementID.Text
                command.Parameters.Add("@Description", SqlDbType.VarChar).Value = TextBoxDesc.Text
                command.Parameters.Add("@Cost_excl", SqlDbType.Decimal).Value = Convert.ToDecimal(TextBoxCostEx.Text)
                command.Parameters.Add("@Cost_incl", SqlDbType.Decimal).Value = Convert.ToDecimal(CostIncl)
                command.Parameters.Add("@Min_levels", SqlDbType.Int).Value = Convert.ToInt32(TextBoxMinLvl.Text)
                command.Parameters.Add("@Current_stock_levels", SqlDbType.Int).Value = Convert.ToInt32(TextBoxCurLvl.Text)
                command.Parameters.Add("@Nappi_code", SqlDbType.VarChar).Value = TextBoxNapppi.Text
                command.Parameters.Add("@Supplier_ID", SqlDbType.VarChar).Value = ComboBoxSupplierID.SelectedValue

                'Open Connection
                connection.Open()

                'Execute SQL Statement
                command.ExecuteNonQuery()
                MessageBox.Show("Supplement ID " & TextBoxSupplementID.Text & " has been added to the Supplement Database.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)


                connection.Close()
                AltHealthSupplementInfo.Refresh_Supplements()
                Me.Close()

            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        'If user Clicks on Yes, then the Supplement Info Add Screen is closed. If the user clicks on No, then the Supplement Info Add Screen is still visible for the user
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to cancel?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub AltHealthSupplementInfoAdd_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'SQL to load Supplier information from the DB into the ComboBox
        Dim adapter As New SqlDataAdapter("SELECT * From tblSupplier_Info", connection)

        'Data is stored in a Temp Table and Displayed in the Combobox
        Dim table As New DataTable()
        adapter.Fill(table)
        ComboBoxSupplierID.DataSource = table
        ComboBoxSupplierID.DisplayMember = "Supplier_ID"
        ComboBoxSupplierID.ValueMember = "Supplier_ID"
    End Sub

    Private Sub TextBoxMinLvl_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxMinLvl.KeyPress
        'Validtion to only allow numbers in the textbox
        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxCurLvl_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxCurLvl.KeyPress
        'Validtion to only allow numbers in the textbox
        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBoxCostEx_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxCostEx.KeyPress
        'Validtion to only allow numbers and decimal sign in the textbox
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
    End Sub

    Private Sub TextBoxSupplementID_Leave(sender As Object, e As System.EventArgs) Handles TextBoxSupplementID.Leave
        ' Dim connection As New SqlConnection("Server = GERRITRENTIA-PC\SQLEXPRESS; Database =  AltHealth; Integrated Security=True")
        'Once the Supplement ID is entered it is validated in the DB to see if it is existing.
        connection.Open()
        Dim command As New SqlCommand("select count(*) from tblSupplements where Supplement_id = '" & TextBoxSupplementID.Text & "'", connection)
        Dim count = Convert.ToInt32(command.ExecuteScalar)

        'If it is existing, the user is informed and the textbox is cleared
        If count > 0 Then
            MessageBox.Show("Supplement ID already Exists", "Supplement Existing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TextBoxSupplementID.Clear()
            TextBoxSupplementID.Focus()
        End If

        connection.Close()
    End Sub

    Private Sub TextBoxCostEx_Leave(sender As Object, e As System.EventArgs) Handles TextBoxCostEx.Leave
        'Once the Value is entered into the Cost Excluding Vat, the Value incl VAT is Calculated automatically
        Dim CostIncl As Decimal = (Convert.ToDecimal(TextBoxCostEx.Text) * VAT) + Convert.ToDecimal(TextBoxCostEx.Text)
        TextBoxCostInc.Text = CostIncl
    End Sub
End Class