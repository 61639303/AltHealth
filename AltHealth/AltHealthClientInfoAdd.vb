Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class AltHealthClientInfoAdd

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to cancel?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click


        If TextBoxClientID.Text = "" Or TextBoxName.Text = "" Or TextBoxSurname.Text = "" Then
            MessageBox.Show("ID Number, Name and Surname are Mandatory Fields, please enter and try again", "Mandatory Fields not filled in", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to add the new Client?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                'add code to push all data to database
                Me.Close()
            End If
        End If
    End Sub

    Private Sub AltHealthClientInfoAdd_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim connection As New SqlConnection("Server = GERRITRENTIA-PC\SQLEXPRESS; Database =  AltHealth; Integrated Security=True")
        Dim adapter As New SqlDataAdapter("SELECT * From tblReference", connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        ComboBoxReference.DataSource = table
        ComboBoxReference.DisplayMember = "Description"
        ComboBoxReference.ValueMember = "Reference_ID"
    End Sub

    Public Function Validate_SAID(ByVal ID As String) As Boolean
        Try
            Dim a As Integer = 0
            For i As Integer = 0 To 5
                a += CInt(id.Substring(i * 2, 1))
            Next

            Dim b As Integer = 0
            For i As Integer = 0 To 5
                b = b * 10 + CInt(id.Substring(2 * i + 1, 1))
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
            If d = CInt(id.Substring(12, 1)) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function validate_Email(emailAddress) As Boolean

        Dim email As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
        If email.IsMatch(emailAddress) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub TextBoxClientID_Leave(sender As Object, e As System.EventArgs) Handles TextBoxClientID.Leave

        Dim ID As String = TextBoxClientID.Text
        Dim IDisValid As Boolean = Validate_SAID(ID)


        If IDisValid = True Then
            ID = TextBoxClientID.Text
        Else
            MessageBox.Show("ID Number is not valid, please enter again", "Invalid ID Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBoxClientID.Text = ""

        End If
    End Sub

    Private Sub TextBoxEmail_Leave(sender As Object, e As System.EventArgs) Handles TextBoxEmail.Leave

        Dim email As String = TextBoxEmail.Text
        Dim EMAILisValid As Boolean = validate_Email(email)

        If EMAILisValid = True Then
            email = TextBoxEmail.Text
        Else
            MessageBox.Show("Email is not valid, please enter again", "Invalid ID Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBoxEmail.Text = ""
        End If
    End Sub

   



End Class