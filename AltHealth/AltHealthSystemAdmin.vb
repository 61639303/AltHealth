Imports System.Data.SqlClient
Imports Microsoft.Office.Interop

Public Class AltHealthSystemAdmin

    'Variable to Connect to Database
    Dim connection As New SqlConnection("Server = GERRITRENTIA-PC\SQLEXPRESS; Database =  AltHealth; Integrated Security=True")

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to close the System Administration screen?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'If user Clicks on Yes, then the System Admin Screen is closed. If the user clicks on No, then the System Admin Screen is still visible for the user
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnRecover_Click(sender As System.Object, e As System.EventArgs) Handles btnRecover.Click

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to restore the database to the latest backed up version?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'If user Clicks on Yes, then the System Admin Screen is closed. If the user clicks on No, then the System Admin Screen is still visible for the user
        If result = DialogResult.Yes Then
            'Connection is opened up to DB
            connection.Open()

            'Sql Command to Restore tha DB
            Dim command As New SqlCommand("USE Master ALTER DATABASE [AltHealth] SET Single_User WITH Rollback Immediate Restore database [AltHealth] FROM disk=N'c:\Program Files (x86)\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\Backup\AltHealth.bak' WITH REPLACE ALTER DATABASE [AltHealth] SET Multi_User", connection)

            'SQL Query is executed
            command.ExecuteNonQuery()


            'Confirmation message to inform user that the record has been written to the DB
            MessageBox.Show("Database has been restored.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Connection is closed
            connection.Close()
        End If


    End Sub

    Private Sub btnHelp_Click(sender As System.Object, e As System.EventArgs) Handles btnHelp.Click
        'Code that opens the User Manual from the Project Folder

        Dim objWord As New Word.Application
        objWord.Visible = True
        'Opens word document
        objWord.Documents.Open("C:\Users\GerritRentia\Documents\ICT3715\Assignment 4\AltHealth\AltHealth\Resources\AltHealth User Manual V1.docx", , , True)
    End Sub
End Class