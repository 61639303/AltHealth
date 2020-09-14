Public Class AltHealthSystemAdmin

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to close the System Administration screen?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'If user Clicks on Yes, then the System Admin Screen is closed. If the user clicks on No, then the System Admin Screen is still visible for the user
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class