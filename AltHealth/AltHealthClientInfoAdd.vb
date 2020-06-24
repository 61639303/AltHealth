Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class AltHealthClientInfoAdd

    'Variable to Connect to Database
    Dim connection As New SqlConnection("Server = GERRITRENTIA-PC\SQLEXPRESS; Database =  AltHealth; Integrated Security=True")

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to cancel?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'If user Clicks on Yes, then the Client Info Add Screen is closed. If the user clicks on No, then the Client Info Add Screen is still visible for the user
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click

        'Check if any of the 3 mandatory fields are blank when the OK Button is pressed
        If TextBoxClientID.Text = "" Or TextBoxName.Text = "" Or TextBoxSurname.Text = "" Then
            MessageBox.Show("ID Number, Name and Surname are Mandatory Fields, please enter and try again", "Mandatory Fields not filled in", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'If all Mandatory fields are filled in, confirmation is asked from the user
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to add the new Client?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            'If yes is clicked, then the textbox and dropdown values are written to the DB, If no is clicked, then the Add screen is still displayed
            If result = DialogResult.Yes Then
                'Sql Command to insert row into DB
                Dim command As New SqlCommand("Insert into tblClientInfo (Client_id, C_name, C_surname, Address, Code, C_Tel_H, C_Tel_W, C_Tel_C, C_Email, Reference_ID) values (@Client_id,@C_name,@C_surname,@Address,@Code,@C_Tel_H,@C_Tel_W,@C_Tel_C,@C_Email,@Reference_ID)", connection)

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
                command.Parameters.Add("@Reference_ID", SqlDbType.VarChar).Value = ComboBoxReference.SelectedText
                command.Parameters.Add("@C_Tel_H", SqlDbType.VarChar).Value = homephone
                command.Parameters.Add("@C_Tel_W", SqlDbType.VarChar).Value = workphone
                command.Parameters.Add("@C_Tel_C", SqlDbType.VarChar).Value = cellphone

                'Connection is opened up to DB
                connection.Open()

                'SQL Query is executed
                command.ExecuteNonQuery()

                'Confirmation message to inform user that the record has been written to the DB
                MessageBox.Show("Client ID " & TextBoxClientID.Text & " has been added to the Client Database.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'Connection is closed
                connection.Close()

                'Call Function to Refresh Data on previous screen
                AltHealthClientInfo.Refresh_ClientInfo()

                Me.Close()

            End If
        End If
    End Sub

    Private Sub AltHealthClientInfoAdd_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'SQL Query that loads the Data to the Combobox for selection
        Dim adapter As New SqlDataAdapter("SELECT * From tblReference", connection)

        'Data is stored in a Temp Table and Displayed in the Combobox
        Dim table As New DataTable()
        adapter.Fill(table)
        ComboBoxReference.DataSource = table
        ComboBoxReference.DisplayMember = "Description"
        ComboBoxReference.ValueMember = "Reference_ID"
    End Sub

    'Function to validate if the ID is a South African ID
    'The Function uses Luhn Algorithm to determine if the ID is valid or Not
    'The Function Returns a TRUE or FALSE Value
    Public Function Validate_SAID(ByVal ID As String) As Boolean
        Try
            Dim a As Integer = 0
            For i As Integer = 0 To 5
                a += CInt(ID.Substring(i * 2, 1))
            Next

            Dim b As Integer = 0
            For i As Integer = 0 To 5
                b = b * 10 + CInt(ID.Substring(2 * i + 1, 1))
            Next
            b *= 2
            Dim c As Integer = 0
            Do
                c += b Mod 10
                b = Int(b / 10)
            Loop Until b <= 0
            c += a
            Dim d As Integer = 0
            d = 10 - (c Mod 10)
            If (d = 10) Then d = 0
            If d = CInt(ID.Substring(12, 1)) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    'Function to determine if the Email Address is valid or not
    'The Function uses REGEXP to determine if the email is valid or not. 
    'The Function returns a TRUE or FALSE Value
    Public Function validate_Email(emailAddress) As Boolean
        Dim email As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
        If email.IsMatch(emailAddress) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub TextBoxClientID_Leave(sender As Object, e As System.EventArgs) Handles TextBoxClientID.Leave

        'The ID of the client is temporarily stored in a Variable
        Dim ID As String = TextBoxClientID.Text

        'The ID is pushed into the Function and a TRUE or FALSE Value is returned
        Dim IDisValid As Boolean = Validate_SAID(ID)

        'If the ID is Valid, The DB is opened up and a check is done to see if the ID is not Existing in the DB
        If IDisValid = True Then
            connection.Open()
            Dim command As New SqlCommand("select count(*) from tblClientInfo where Client_id = '" & TextBoxClientID.Text & "'", connection)
            Dim count = Convert.ToInt32(command.ExecuteScalar)
            ' If the ID is Valid and Existing, a message is displayed to the user and the textboxes are cleared
            If count > 0 Then
                MessageBox.Show("Client ID already Exists", "Client Existing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                TextBoxClientID.Clear()
                TextBoxClientID.Focus()
            End If
            ' The connection is closed
            connection.Close()
            'If the ID is valid and not Existing, the ID is stored in a Variable
            ID = TextBoxClientID.Text
        Else

            'If the ID is not Valid, a message is displayed to the User to try again
            MessageBox.Show("ID Number is not valid, please enter again", "Invalid ID Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBoxClientID.Text = ""

        End If
    End Sub

    Private Sub TextBoxEmail_Leave(sender As Object, e As System.EventArgs) Handles TextBoxEmail.Leave

        'The email of the client is temporarily stored in a Variable
        Dim email As String = TextBoxEmail.Text

        'The Email is pushed into the Function and a TRUE or FALSE Value is returned
        Dim EMAILisValid As Boolean = validate_Email(email)

        'If the Email is valid, then it is stored in a variable
        If EMAILisValid = True Then
            email = TextBoxEmail.Text
        Else

            'If the email is not a valid email, the user is informed and the textbox is cleared
            MessageBox.Show("Email is not valid, please enter again", "Invalid ID Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBoxEmail.Text = ""
        End If
    End Sub




End Class