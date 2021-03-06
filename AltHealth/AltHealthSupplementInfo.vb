﻿Imports System.Data.SqlClient

Public Class AltHealthSupplementInfo

    'Variable to Connect to Database
    Dim connection As New SqlConnection("Server = GERRITRENTIA-PC\SQLEXPRESS; Database =  AltHealth; Integrated Security=True")

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to close the Supplement Information screen?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'If user Clicks on Yes, then the Supplement Info Screen is closed. If the user clicks on No, then the Supplement Info Screen is still visible for the user
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub


    Private Sub AltHealthSupplementInfo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Calls Function to Refresh Data in Data Grid View
        Refresh_Supplements()
    End Sub

    Private Sub btnNewSupplement_Click(sender As System.Object, e As System.EventArgs) Handles btnNewSupplement.Click

        'Temporarily Disables the Supplemetn Info Screen and Opens the Supplement Info Add Screen
        Dim form = New AltHealthSupplementInfoAdd()
        form.ShowDialog()
    End Sub

    Private Sub DataGridViewSupplementInfo_CellContentDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewSupplementInfo.CellContentDoubleClick

        'Temporarily Disables the Supplement Info Screen and Opens the Supplement Info Display Screen
        Dim form As New AltHealthSupplementInfoDisplay()

        'Fills the Textboxes in the Form with the values of the selected Row from the Datadrid
        form.TextBoxSupplementID.Text = DataGridViewSupplementInfo.CurrentRow.Cells(0).Value.ToString()
        form.TextBoxDesc.Text = DataGridViewSupplementInfo.CurrentRow.Cells(1).Value.ToString()
        form.TextBoxCostEx.Text = DataGridViewSupplementInfo.CurrentRow.Cells(2).Value.ToString()
        form.TextBoxCostInc.Text = DataGridViewSupplementInfo.CurrentRow.Cells(3).Value.ToString()
        form.TextBoxMinLvl.Text = DataGridViewSupplementInfo.CurrentRow.Cells(4).Value.ToString()
        form.TextBoxCurLvl.Text = DataGridViewSupplementInfo.CurrentRow.Cells(5).Value.ToString()
        form.TextBoxNapppi.Text = DataGridViewSupplementInfo.CurrentRow.Cells(6).Value.ToString()
        form.TextBoxSupplierID.Text = DataGridViewSupplementInfo.CurrentRow.Cells(7).Value.ToString()
        form.ShowDialog()
    End Sub

    Public Sub Refresh_Supplements()

        'Function that Fills Data in the Data Grid View
        Dim adapter As New SqlDataAdapter("SELECT  Supplement_id as 'Supplement ID', Description, Cost_excl as 'Cost Excluding VAT', Cost_incl as 'Cost Including VAT', Min_levels as 'Minimum Stock Level', Current_stock_levels as 'Current Stock Level', Nappi_code as 'Nappi Code', Supplier_ID as ' Supplier ID' From tblSupplements", connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridViewSupplementInfo.DataSource = table

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

        'Code that loops through the Datagrid view and writes the data to the file
        For i = 0 To DataGridViewSupplementInfo.RowCount - 2

            'Progress bar update
            ProgressBar1.Value = Int(i * (ProgressBar1.Maximum / DataGridViewSupplementInfo.RowCount))
            My.Application.DoEvents()

            For j = 0 To DataGridViewSupplementInfo.ColumnCount - 1
                For k As Integer = 1 To DataGridViewSupplementInfo.Columns.Count
                    xlWorkSheet.Cells(1, k) = DataGridViewSupplementInfo.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = DataGridViewSupplementInfo(j, i).Value.ToString()
                Next
            Next
        Next

        'Variable to store the filename with Date and Time Object
        Dim timeStamp As DateTime = DateTime.Now

        'Save the file to the Drive
        xlWorkSheet.SaveAs(path & "\Supplement Information Report " & timeStamp.ToString("yyyymmddhhmmss") & ".csv")

        'Close Excel Object
        xlWorkBook.Close()
        xlApp.Quit()

        'Hide the Progress Bar
        ProgressBar1.Visible = False

        'Inform the User that the Report has been exported
        MsgBox("The Report has been exported.")
        Me.Show()


    End Sub

    Private Sub btnAddStock_Click(sender As System.Object, e As System.EventArgs)
        'Temporarily Disables the Supplemetn Info Screen and Opens the Supplement Info Add Screen
        Dim form = New AltHealthSupplementInfoAdd()
        form.ShowDialog()
    End Sub
End Class