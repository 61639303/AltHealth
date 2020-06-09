Public Class AltHealthHome

    Private Sub btnClientInfo_Click(sender As System.Object, e As System.EventArgs) Handles btnClientInfo.Click
        Dim form = New AltHealthClientInfo()
        form.ShowDialog()
    End Sub

    Private Sub btnSupplierInfo_Click(sender As System.Object, e As System.EventArgs) Handles btnSupplierInfo.Click
        Dim form = New AltHealthSupplierInfo()
        form.ShowDialog()
    End Sub

    Private Sub btnSupplementInfo_Click(sender As System.Object, e As System.EventArgs) Handles btnSupplementInfo.Click
        Dim form = New AltHealthSupplementInfo()
        form.ShowDialog()
    End Sub

    Private Sub btnReporting_Click(sender As System.Object, e As System.EventArgs) Handles btnReporting.Click
        Dim form = New AltHealthReporting()
        form.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit the AltHealth Application?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class
