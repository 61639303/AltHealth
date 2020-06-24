Imports System.Text.RegularExpressions
Imports System.Data.SqlClient

Public Class AltHealthSupplierInfoAdd

    'Variable to Connect to Database
    Dim connection As New SqlConnection("Server = GERRITRENTIA-PC\SQLEXPRESS; Database =  AltHealth; Integrated Security=True")

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click

        'Check if the mandatory fields are blank when the OK Button is pressed
        If TextBoxSupplierID.Text = "" Or TextBoxContact.Text = "" Then

            MessageBox.Show("Supplier ID and Contact Person are Mandatory Fields, please enter and try again", "Mandatory Fields not filled in", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            'If all Mandatory fields are filled in, confirmation is asked from the user
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to add the new Supplier?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                'If yes is clicked, then the textbox and dropdown values are written to the DB, If no is clicked, then the Add screen is still displayed
                Dim command As New SqlCommand("Insert into tblSupplier_Info (Supplier_ID, Contact_Person, Supplier_Tel, Supplier_Email, Bank, Bank_code, Supplier_BankNum, Supplier_Type_Bank_Account) values (@Supplier_ID,@Contact_Person,@Supplier_Tel,@Supplier_Email,@Bank,@Bank_code,@Supplier_BankNum,@Supplier_Type_Bank_Account)", connection)

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
                MessageBox.Show("Client ID " & TextBoxSupplierID.Text & " has been added to the Supplier Database.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'Connection is closed
                connection.Close()

                Me.Close()

            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        'If user Clicks on Yes, then the Supplier Info Add Screen is closed. If the user clicks on No, then the Supplier Info Add Screen is still visible for the user
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to cancel?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Public Function validate_Email(emailAddress) As Boolean

        'Function that Validated with REGEX the Email Address
        'Stores and returns either a TRUE or FALSE Value
        Dim email As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
        If email.IsMatch(emailAddress) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub TextBoxEmail_Leave(sender As Object, e As System.EventArgs) Handles TextBoxEmail.Leave

        'Once the Textbox is filled in, the function is called to validate if the email address is a valid email
        Dim email As String = TextBoxEmail.Text
        Dim EMAILisValid As Boolean = validate_Email(email)

        If EMAILisValid = True Then
            email = TextBoxEmail.Text
        Else
            MessageBox.Show("Email is not valid, please enter again", "Invalid ID Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub TextBoxSupplierID_Leave(sender As Object, e As System.EventArgs) Handles TextBoxSupplierID.Leave

        'Once the Supplier Id is entered it is validated against the DB to check if it is already existing. 
        connection.Open()
        Dim command As New SqlCommand("select count(*) from tblSupplier_Info where Supplier_ID = '" & TextBoxSupplierID.Text & "'", connection)
        Dim count = Convert.ToInt32(command.ExecuteScalar)

        If count > 0 Then
            MessageBox.Show("Supplement ID already Exists", "Supplement Existing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TextBoxSupplierID.Clear()
            TextBoxSupplierID.Focus()
        End If

        connection.Close()
    End Sub



End Class