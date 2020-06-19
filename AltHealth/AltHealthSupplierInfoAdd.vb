Imports System.Text.RegularExpressions

Public Class AltHealthSupplierInfoAdd

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click

        If TextBoxSupplierID.Text = "" Or TextBoxContact.Text = "" Then

            MessageBox.Show("Supplier ID and Contact Person are Mandatory Fields, please enter and try again", "Mandatory Fields not filled in", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to add the new Supplier?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                'Add code to push data to database
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to cancel?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Public Function validate_Email(emailAddress) As Boolean

        Dim email As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
        If email.IsMatch(emailAddress) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub TextBoxEmail_Leave(sender As Object, e As System.EventArgs) Handles TextBoxEmail.Leave

        Dim email As String = TextBoxEmail.Text
        Dim EMAILisValid As Boolean = validate_Email(email)

        If EMAILisValid = True Then
            email = TextBoxEmail.Text
        Else
            MessageBox.Show("Email is not valid, please enter again", "Invalid ID Number", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

 
End Class