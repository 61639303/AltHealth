Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports System.Net.Mail
Imports System.Text

Public Class AltHealthInvoices
    'Constant declared for VAT
    Const VAT = 0.15
    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to close the Invoices screen?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub AltHealthInvoices_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Clear all textbox when form loads
        lblClientID.Text = ""
        lblInvDate.Text = ""
        lblInvPaidDate.Text = ""
        lblClientName.Text = ""
        lblClientAddress.Text = ""
        lblClientHome.Text = ""
        lblClientWork.Text = ""
        lblClientCell.Text = ""
        lblClientEmail.Text = ""
        txtBoxInvoiceNumber.Clear()
        txtBoxInvoiceNumber.Focus()
        txtBoxInvoiceNumber.Select(3, 1)
    End Sub

    Private Sub Populate_Invoice(ByVal Inv_nr As String)

        Dim connection As New SqlConnection("Server = GERRITRENTIA-PC\SQLEXPRESS; Database =  AltHealth; Integrated Security=True")
        Dim adapter2 As New SqlDataAdapter("SELECT * From tblInv_info where Inv_Num = '" & Inv_nr & "'", connection)
        Try
            Dim table2 As New DataTable()

            adapter2.Fill(table2)

            GroupBoxInv.Text = Inv_nr
            lblInvDate.Text = table2(0)(1)
            If table2(0)(2) = "Y" Then
                lblInvPaidDate.Text = table2(0)(3)
            Else : lblInvPaidDate.Text = ""
            End If

            lblClientID.Text = table2(0)(5)

            Dim adapter3 As New SqlDataAdapter("SELECT * From tblClientInfo where Client_id = " & lblClientID.Text, connection)
            Dim table3 As New DataTable()
            adapter3.Fill(table3)
            lblClientName.Text = table3(0)(1) & "" & table3(0)(2)
            lblClientAddress.Text = table3(0)(3) & " " & table3(0)(4)
            lblClientHome.Text = table3(0)(5)
            lblClientWork.Text = table3(0)(6)
            lblClientCell.Text = table3(0)(7)
            lblClientEmail.Text = table3(0)(8)

            Dim adapter As New SqlDataAdapter("select Supplement_id as Item, Item_price as Price, Item_quantity as QTY, (Item_price * Item_quantity) as Total from tblInv_Items where Inv_Num = '" & Inv_nr & "'", connection)
            Dim table As New DataTable()
            adapter.Fill(table)
            DataGridViewInvoiceItems.DataSource = table

            Dim totalExc As Decimal

            For Each row As DataGridViewRow In DataGridViewInvoiceItems.Rows
                If row.Cells(3).Value > 0 Then
                    totalExc += row.Cells(3).Value
                End If
            Next

            '  Dim totalex As Decimal
            Dim totalVat As Decimal
            Dim totalInc As Decimal


            Dim symbol As String = "R "
            lblTotalExcl.Text = String.Format("{0:" + symbol + "#,##0.00}", totalExc)
            totalVat = lblTotalExcl.Text * VAT
            lblTotalVat.Text = String.Format("{0:" + symbol + "#,##0.00}", totalVat)
            totalInc = totalExc + totalVat
            lblTotalIncl.Text = String.Format("{0:" + symbol + "#,##0.00}", totalInc)



        Catch ex As Exception
            MessageBox.Show("Invoice Number does not Exist. Please Enter the Correct Invoice Number.", "Invoice Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBoxInvoiceNumber.Select(3, 5)
            txtBoxInvoiceNumber.Focus()
        End Try
    End Sub



    Private Sub txtBoxInvoiceNumber_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtBoxInvoiceNumber.KeyDown
        'When enter is pressed, invoice number is searched  and function to populate values are called
        If e.KeyCode = Keys.Enter Then

            Dim Inv_Num As String
            Inv_Num = txtBoxInvoiceNumber.Text

            Me.Populate_Invoice(Inv_Num)
            txtBoxInvoiceNumber.Clear()
            txtBoxInvoiceNumber.Focus()
            txtBoxInvoiceNumber.Select(3, 1)
        End If
    End Sub

    Public Sub Send_Email()

        Try
            'Connect to Gmail with User ID adn Password
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Dim attachment As System.Net.Mail.Attachment

            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("gvanniekerk000@gmail.com", "MyGvannie01*")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"
            Smtp_Server.DeliveryMethod = SmtpDeliveryMethod.Network
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls


            e_mail = New MailMessage()
            e_mail.From = New MailAddress("gvanniekerk@daimler.com")
            e_mail.To.Add(lblClientEmail.Text)
            e_mail.Subject = "AltHealth Invoice Number: " & GroupBoxInv.Text
            e_mail.IsBodyHtml = False


            'Add Attachment to email
            attachment = New System.Net.Mail.Attachment("C:\Users\GerritRentia\Documents\ICT3715\Invoices\" & GroupBoxInv.Text & ".docx") 'file path
            e_mail.Attachments.Add(attachment)

            'Substring for Email Body
            Dim sb As New StringBuilder
            sb.AppendLine("Dear " & lblClientName.Text & "," & vbNewLine)
            sb.AppendLine(vbNewLine & "Thank you for your Purchase, attached, please find a copy of your invoice")
            sb.AppendLine("For any queries, please feel free to contact us" & vbNewLine)
            sb.AppendLine("Regards")
            sb.AppendLine("AltHealth Management")
            sb.AppendLine()

            e_mail.Body = sb.ToString()
            Smtp_Server.Send(e_mail)

            'Confirmation Messge after email has been sent
            MsgBox("Mail Sent")


        Catch error_t As Exception
            MsgBox("No Email Address found. Invoice not Sent to Client")
        End Try


    End Sub

    Public Sub Generate_Invoice()

        'Declare the Word Document Variables
        Dim oWord As Word.Application
        Dim oDoc As Word.Document
        Dim oPara1 As Word.Paragraph, oPara2 As Word.Paragraph
        Dim oPara3 As Word.Paragraph



        'Start Word and open the document template.
        oWord = CreateObject("Word.Application")

        'If activated, this will Open MS Word and then generate the invoice
        '   oWord.Visible = True
        oDoc = oWord.Documents.Add

        'Insert a paragraph at the beginning of the document with Invoice Data.
        oPara1 = oDoc.Content.Paragraphs.Add
        oPara1.Range.Font.Bold = True
        oPara1.Range.Font.Size = 16
        oPara1.Format.SpaceBefore = 1
        oPara1.Range.InsertParagraphBefore()
        oPara1.Range.Text = "Invoice Number: " & GroupBoxInv.Text & vbNewLine & "Invoice Date: " & lblInvDate.Text & vbNewLine
        oPara1.Format.SpaceAfter = 1
        oPara1.Range.InsertParagraphAfter()

        'Insert customer informtion to Invoice
        oPara2 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara2.Range.Font.Bold = True
        oPara2.Range.Text = "Client Name: " & lblClientName.Text & vbNewLine &
        "Client Address: " & lblClientAddress.Text & vbNewLine &
        "Home Phone: " & lblClientHome.Text & vbNewLine &
        "Work Phone: " & lblClientWork.Text & vbNewLine &
        "Cell Phone: " & lblClientCell.Text & vbNewLine &
        "Email: " & lblClientEmail.Text & vbNewLine
        oPara2.Range.InsertParagraphAfter()


        'Code to add all suplements in the datagrid view to the invoice
        Dim rowCount As Integer = DataGridViewInvoiceItems.Rows.Count - 1
        Dim colCount As Integer = DataGridViewInvoiceItems.Columns.Count - 1

        Dim table As Word.Table

        table = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, rowCount + 1, colCount + 1)
        table.Borders.OutsideColor = Word.WdColor.wdColorBlack
        table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle
        table.Borders.InsideColor = Word.WdColor.wdColorBlack
        table.Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle

        For i As Integer = 0 To rowCount

            For _col As Integer = 0 To colCount
                Dim colType As Type = DataGridViewInvoiceItems.Columns(_col).GetType
                If colType.Name = "DataGridViewImageColumn" Then
                    Dim _image As Image = DirectCast(DataGridViewInvoiceItems.Rows(i).Cells(_col).Value, Image)
                    Clipboard.SetImage(_image)
                    table.Cell(i + 1, _col + 1).Range.Paste()
                Else
                    table.Cell(i + 1, _col + 1).Range.Text = _
                    DataGridViewInvoiceItems.Rows(i).Cells(_col).Value.ToString()
                End If
            Next
        Next


        'Insert Totals
        oPara3 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara3.Range.Font.Bold = True
        oPara3.Range.Font.Size = 12
        oPara3.Range.Text = vbNewLine & "Total Excluding: " & lblTotalExcl.Text & vbNewLine &
        "VAT @ 15%: " & lblTotalVat.Text & vbNewLine &
        "Total Including: " & lblTotalIncl.Text & vbNewLine
        oPara3.Range.InsertParagraphAfter()

        'Save Document to local harddrive
        Try
            oDoc.SaveAs("C:\Users\GerritRentia\Documents\ICT3715\Invoices\" & GroupBoxInv.Text & ".docx")
            oDoc.Close()
            oWord.Quit()
        Catch error_t As Exception
            '    MsgBox(error_t.ToString)
        End Try


    End Sub


    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Generate and email the invoice to the customer ?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Generate_Invoice()
            Send_Email()
        End If



    End Sub
End Class
