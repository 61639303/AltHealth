Imports System.Data.SqlClient

Public Class AltHealthSupplierInfo

    'Variable to Connect to Database
    Dim connection As New SqlConnection("Server = GERRITRENTIA-PC\SQLEXPRESS; Database =  AltHealth; Integrated Security=True")


    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to close the Supplier Information screen?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'If user Clicks on Yes, then the Supplier Info Screen is closed. If the user clicks on No, then the Supplier Info Screen is still visible for the user
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub AltHealthSupplierInfo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'Calls Function to Refresh Data in Data Grid View
        Refresh_SupplierInfo()
    End Sub

    Private Sub btnNewSupplier_Click(sender As System.Object, e As System.EventArgs) Handles btnNewSupplier.Click

        'Temporarily Disables the Supplier Info Screen and Opens the Supplier Info Add Screen
        Dim form = New AltHealthSupplierInfoAdd()
        form.ShowDialog()

    End Sub

    Private Sub DataGridViewSupplierInfo_CellContentDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewSupplierInfo.CellContentDoubleClick

        'Temporarily Disables the Supplier Info Screen and Opens the Supplier Info Display Screen
        Dim form As New AltHealthSupplierInfoDisplay()

        'Fills the Textboxes in the Form with the values of the selected Row from the Datadrid
        form.TextBoxSupplierID.Text = DataGridViewSupplierInfo.CurrentRow.Cells(0).Value.ToString()
        form.TextBoxContact.Text = DataGridViewSupplierInfo.CurrentRow.Cells(1).Value.ToString()
        form.TextBoxTel.Text = DataGridViewSupplierInfo.CurrentRow.Cells(2).Value.ToString()
        form.TextBoxEmail.Text = DataGridViewSupplierInfo.CurrentRow.Cells(3).Value.ToString()
        form.TextBoxBank.Text = DataGridViewSupplierInfo.CurrentRow.Cells(4).Value.ToString()
        form.TextBoxCode.Text = DataGridViewSupplierInfo.CurrentRow.Cells(5).Value.ToString()
        form.TextBoxBankNr.Text = DataGridViewSupplierInfo.CurrentRow.Cells(6).Value.ToString()
        form.TextBoxType.Text = DataGridViewSupplierInfo.CurrentRow.Cells(7).Value.ToString()
        form.ShowDialog()

    End Sub

    Public Sub Refresh_SupplierInfo()

        'Function that Fills Data in the Data Grid View
        Dim adapter As New SqlDataAdapter("SELECT Supplier_ID as 'Supplier ID', Contact_Person as 'Contact Person', Supplier_Tel as ' Telephone Nr',Supplier_Email as 'Email',  Bank, Bank_code as 'Bank Code', Supplier_BankNum as 'Account Nr', Supplier_Type_Bank_Account as 'Account Type' From tblSupplier_Info", connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridViewSupplierInfo.DataSource = table
        DataGridViewSupplierInfo.Refresh()


    End Sub

    Private Sub btnExport_Click(sender As System.Object, e As System.EventArgs) Handles btnExport.Click

        'Code to export the Data to Excel
        'make Progress Bar Visible
        ProgressBar1.Visible = True

        'Variable to Store the user selected path
        Dim path As String
        FolderBrowserDialog1.ShowDialog()
        path = FolderBrowserDialog1.SelectedPath

        'Open Excel Object
        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value

        'Variables to write data to file with For Loop
        Dim i As Integer
        Dim j As Integer
        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")
        xlWorkSheet.Columns.AutoFit()

        ' Code that loops through the Datagrid view and writes the data to the file
        For i = 0 To DataGridViewSupplierInfo.RowCount - 2
            'Progress bar update
            ProgressBar1.Value = Int(i * (ProgressBar1.Maximum / DataGridViewSupplierInfo.RowCount))
            My.Application.DoEvents()

            For j = 0 To DataGridViewSupplierInfo.ColumnCount - 1
                For k As Integer = 1 To DataGridViewSupplierInfo.Columns.Count
                    xlWorkSheet.Cells(1, k) = DataGridViewSupplierInfo.Columns(k - 1).HeaderText

                    xlWorkSheet.Cells(i + 2, j + 1) = DataGridViewSupplierInfo(j, i).Value.ToString()
                Next
            Next
        Next

        'Variable to store the filename with Date and Time Object
        Dim timeStamp As DateTime = DateTime.Now

        'Save the file to the Drive
        xlWorkSheet.SaveAs(path & "\Supplier Information Report " & timeStamp.ToString("yyyymmddhhmmss") & ".csv")

        'Close Excel Object
        xlWorkBook.Close()
        xlApp.Quit()

        'Hide the Progress Bar
        ProgressBar1.Visible = False

        'Inform the User that the Report has been exported
        MsgBox("The Report has been exported.")
        Me.Show()




    End Sub

    
End Class