Public Class AltHealthShoppingCart

    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to close the Shoping Cart screen? All information in the cart will be lost!", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class