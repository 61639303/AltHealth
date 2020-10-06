Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.Text
Imports Microsoft.Office.Interop


Public Class AltHealthShoppingCart

    'Variable to Connect to Database
    Dim connection As New SqlConnection("Server = GERRITRENTIA-PC\SQLEXPRESS; Database =  AltHealth; Integrated Security=True")

    'Constant declared for VAT
    Const VAT = 0.15


    Private Sub btnClose_Click(sender As System.Object, e As System.EventArgs) Handles btnClose.Click

        'If user clicks Yes, Nothing is saved and the screen is closed
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to close the Shoping Cart screen? All information in the cart will be lost!", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub AltHealthShoppingCart_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        NumericUpDownQty.Enabled = False
        'Upon Load, Date automatically filled in
        lblInvDate.Text = System.DateTime.Now.ToString("yyyy/MM/dd")

        'Upon Load, Invoice number automatically pulls through from database as next availible invoice nr
        Dim Inv_Num As String = ""
        Inv_Num = Get_Invoice_number(Inv_Num)
        GroupBoxInv.Text = Inv_Num

        'clear all client labels until a client is selected
        lblClientName.Text = ""
        lblClientAddress.Text = ""
        lblClientHome.Text = ""
        lblClientWork.Text = ""
        lblClientCell.Text = ""
        lblClientEmail.Text = ""
        TextBoxStock.Text = "0"
        'SQL Query that loads the Data to the Combobox for selection for Client IDs
        Dim adapter As New SqlDataAdapter("SELECT * From tblClientInfo", connection)

        'Data is stored in a Temp Table and Displayed in the Combobox
        Dim table As New DataTable()
        adapter.Fill(table)
        ComboBoxClientID.DataSource = table
        ComboBoxClientID.DisplayMember = "Client_id"
        ComboBoxClientID.ValueMember = "Client_id"

        ComboBoxClientID.SelectedIndex = -1

        'SQL Query that loads the Data to the Combobox for selection for Supllement IDs
        Dim adapter2 As New SqlDataAdapter("SELECT * From tblSupplements", connection)

        'Data is stored in a Temp Table and Displayed in the Combobox
        Dim table2 As New DataTable()
        adapter2.Fill(table2)
        ComboBoxSupplementID.DataSource = table2
        ComboBoxSupplementID.DisplayMember = "Supplement_id"
        ComboBoxSupplementID.ValueMember = "Supplement_id"

        ComboBoxSupplementID.SelectedIndex = -1


        DataGridViewInvoiceItems.Columns.Add("Item", "Item")
        DataGridViewInvoiceItems.Columns.Add("Description", "Description")
        DataGridViewInvoiceItems.Columns.Add("Qty", "Qty")
        DataGridViewInvoiceItems.Columns.Add("Price", "Price Excl.")

        NumericUpDownQty.Enabled = False
    End Sub

    Private Sub ComboBoxSupplementID_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBoxSupplementID.SelectedIndexChanged

        NumericUpDownQty.Enabled = True
        ' Whenever the Dropdown is changed, the below code updates the textboxes and values of the Supplements
        Try
            Dim supplement_id As String
            supplement_id = ComboBoxSupplementID.SelectedValue


            Dim test As Boolean = True
            For Each row In DataGridViewInvoiceItems.Rows
                If supplement_id = row.Cells("Item").Value Then
                    test = False
                    Exit For
                End If
            Next

            If test = False Then
                TextBoxDescription.Text = " "
                TextBoxExcl.Text = "0.00"
                TextBoxStock.Text = "0"
                MessageBox.Show(Me, "Item Already Added to Shopping Cart, Please delete the Item from the Cart Items and then add the Item Again ", "Item Added Already", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                NumericUpDownQty.Enabled = False
                ComboBoxSupplementID.SelectedIndex = -1

            End If

            Dim adapter As New SqlDataAdapter("Select * from tblSupplements where Supplement_id = '" & supplement_id & "'", connection)
            Dim table As New DataTable()
            adapter.Fill(table)
            TextBoxDescription.Text = table(0)(1)
            TextBoxStock.Text = table(0)(5)
            TextBoxExcl.Text = table(0)(2)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub ComboBoxClientID_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBoxClientID.SelectedIndexChanged

        ' Whenever the Dropdown is changed, the below code updates the textboxes and values of the ID Nrs
        Try

            Dim client_id As String
            client_id = ComboBoxClientID.SelectedValue
            Dim adapter As New SqlDataAdapter("Select * from tblClientInfo where Client_id = '" & client_id & "'", connection)
            Dim table As New DataTable()
            adapter.Fill(table)
            lblClientName.Text = table(0)(1) & " " & table(0)(2)
            lblClientAddress.Text = table(0)(3) & " " & table(0)(4)
            lblClientHome.Text = table(0)(5)
            lblClientWork.Text = table(0)(6)
            lblClientCell.Text = table(0)(7)
            lblClientEmail.Text = table(0)(8)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        If ComboBoxSupplementID.SelectedIndex <> -1 Then
            Dim amt_excl As Decimal = TextBoxExcl.Text
            Dim total_excl As Decimal = amt_excl * Convert.ToInt32(NumericUpDownQty.Value)
            DataGridViewInvoiceItems.Rows.Add(ComboBoxSupplementID.SelectedValue, TextBoxDescription.Text, NumericUpDownQty.Value, total_excl.ToString())

            'Call Functin to Recalculate totals
            Add_Totals()

            'Reset Numeric Up Down Button to 1 every time a new item is added to the cart
            NumericUpDownQty.Value = 1

            '   Dim exceed_stock As Boolean = False
            ComboBoxSupplementID.SelectedIndex = -1
            TextBoxExcl.Text = "0.00"
            TextBoxStock.Text = "0"
            TextBoxDescription.Text = ""
            NumericUpDownQty.Enabled = False
        Else
            MessageBox.Show("Please select a valid Supplement", "No Supplement selected", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If


    End Sub

    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click

        If DataGridViewInvoiceItems.SelectedRows.Count > 0 Then
            'code to remove column from the data grid view
            'If user clicks Yes, Nothing is saved and the screen is closed
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to remove the selected item from the Shoping Cart?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                'Line Item is Removed
                DataGridViewInvoiceItems.Rows.Remove(DataGridViewInvoiceItems.SelectedRows(0))

                'Call Functin to Recalculate totals
                Add_Totals()

            End If
        Else
            MessageBox.Show("Please select a full row of the item that you want to delete", "Select Full Row", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click

        'call function to Write data to Invoice Table. This function also call the function to write to the Invoice Items Table , to generate the invoice and to mail it to the client
        Write_to_Invoice_Table()

    End Sub

    Public Sub Add_Totals()
        'Function that adds all the totals
        Dim totalex As Decimal
        Dim totalVat As Decimal
        Dim totalInc As Decimal

        'Totals are recalculated
        For Each row As DataGridViewRow In DataGridViewInvoiceItems.Rows
            If row.Cells(3).Value > 0 Then
                totalex += row.Cells(3).Value
            End If
        Next
        Dim symbol As String = "R "
        lblTotalInvoiceExVat.Text = String.Format("{0:" + symbol + "#,##0.00}", totalex)
        totalVat = lblTotalInvoiceExVat.Text * VAT
        lblTotalVat.Text = String.Format("{0:" + symbol + "#,##0.00}", totalVat)
        totalInc = totalex + totalVat
        lblTotalInvoice.Text = String.Format("{0:" + symbol + "#,##0.00}", totalInc)
    End Sub

    Public Function Get_Invoice_number(inv_num As String) As String

        'Function that looks up the latest Invoice Number and increments it by 1.
        Dim adapter As New SqlDataAdapter("SELECT Max(Cast(substring(Inv_Num,5,100) as Int)) INV From tblInv_info order by INV asc", connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        inv_num = "INV0" & table(0)(0) + 1
        Return inv_num
    End Function

    Public Sub Write_to_Invoice_Table()


        Dim result As DialogResult = MessageBox.Show("Are you sure you want to print and submit the Invoice?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then

            If ComboBoxClientID.SelectedIndex <> -1 Then

                If DataGridViewInvoiceItems.RowCount > 0 Then
                    'Sql Command to insert row into DB into the Invoice Info table
                    Dim command As New SqlCommand("Insert into tblInv_info (Inv_Num, Inv_Date, Inv_Paid, Inv_Paid_Date, Comments, Client_id) values (@Inv_Num,@Inv_Date,@Inv_Paid, @Inv_Paid_Date,@Comments,@Client_id)", connection)

                    command.Parameters.Add("@Inv_Num", SqlDbType.VarChar).Value = GroupBoxInv.Text
                    command.Parameters.Add("@Inv_Date", SqlDbType.VarChar).Value = System.DateTime.Now.ToString("yyyy/MM/dd")

                    If CheckBoxPaid.Checked = True Then
                        command.Parameters.Add("@Inv_Paid", SqlDbType.VarChar).Value = "Y"
                        command.Parameters.Add("@Inv_Paid_Date", SqlDbType.VarChar).Value = System.DateTime.Now.ToString("yyyy/MM/dd")
                    Else
                        command.Parameters.Add("@Inv_Paid", SqlDbType.VarChar).Value = "N"
                        command.Parameters.Add("@Inv_Paid_Date", SqlDbType.VarChar).Value = DBNull.Value

                    End If

                    command.Parameters.Add("@Comments", SqlDbType.VarChar).Value = ""
                    command.Parameters.Add("@Client_id", SqlDbType.VarChar).Value = ComboBoxClientID.Text


                    'Connection is opened up to DB
                    connection.Open()

                    'SQL Query is executed
                    command.ExecuteNonQuery()

                    Write_to_Invoice_Items_Table()

                    'Confirmation message to inform user that the record has been written to the DB
                    MessageBox.Show("Invoice Nr " & GroupBoxInv.Text & " has been added to the Database.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'Connection is closed
                    connection.Close()


                    ' Call Function to generate a Microsoft Word Document Invoice
                    Generate_Invoice()

                    ' Call Function to Send Invoice Details to Client
                    Send_Email()


                Else
                    MessageBox.Show("No Items has been added to the Shopping Cart", "Shopping Cart Empty", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                MessageBox.Show("Please Select a Customer", "Customer not selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            End If

    End Sub

    Public Sub Write_to_Invoice_Items_Table()
        Dim inv_nr As String
        Dim Supplement_id As String
        Dim Item_price As Decimal
        Dim qty As Integer
        For x As Integer = 0 To DataGridViewInvoiceItems.Rows.Count - 1
            inv_nr = GroupBoxInv.Text
            Supplement_id = DataGridViewInvoiceItems.Rows(x).Cells(0).Value
            qty = DataGridViewInvoiceItems.Rows(x).Cells(2).Value
            Item_price = DataGridViewInvoiceItems.Rows(x).Cells(3).Value

            Dim command2 As New SqlCommand("Insert into tblInv_Items (inv_Num, Supplement_id, Item_price, Item_quantity) values (@inv_nr,@Supplement_id,@Item_price, @qty)", connection)
            command2.Parameters.AddWithValue("@inv_nr", inv_nr)
            command2.Parameters.AddWithValue("@Supplement_id", Supplement_id)
            command2.Parameters.AddWithValue("@Item_price", Item_price)
            command2.Parameters.AddWithValue("@qty", qty)
            command2.ExecuteNonQuery()
            command2.Dispose()

            'Reduce Stock on Hand in Database
            Dim command3 As New SqlCommand("update tblSupplements set Current_stock_levels  = (Current_stock_levels - " & qty & ") where Supplement_id = '" & Supplement_id & "'", connection)
            command3.ExecuteNonQuery()
        Next
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

            'Clear all fields after successful mail sent
            ComboBoxClientID.SelectedIndex = -1
            ComboBoxSupplementID.SelectedIndex = -1
            lblClientName.Text = ""
            lblClientAddress.Text = ""
            lblClientHome.Text = ""
            lblClientWork.Text = ""
            lblClientCell.Text = ""
            lblClientEmail.Text = ""
            DataGridViewInvoiceItems.Rows.Clear()
            CheckBoxPaid.Checked = False
            lblTotalInvoiceExVat.Text = "R0.00"
            lblTotalVat.Text = "R0.00"
            lblTotalInvoice.Text = "R0.00"
            Dim Inv_Num As String = ""

            'Calls Function to get next invoice number in the database
            Inv_Num = Get_Invoice_number(Inv_Num)
            GroupBoxInv.Text = Inv_Num

        Catch error_t As Exception
            MsgBox("No Email Address found. Invoice not Sent to Client. Invoice Generated and Saved")

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
        oPara3.Range.Text = vbNewLine & "Total Excluding: " & lblTotalInvoiceExVat.Text & vbNewLine &
        "VAT @ 15%: " & lblTotalVat.Text & vbNewLine &
        "Total Including: " & lblTotalInvoice.Text & vbNewLine
        oPara3.Range.InsertParagraphAfter()

        'Save Document to local harddrive
        oDoc.SaveAs("C:\Users\GerritRentia\Documents\ICT3715\Invoices\" & GroupBoxInv.Text & ".docx")
        oDoc.Close()
        oWord.Quit()


    End Sub

    Private Sub NumericUpDownQty_ValueChanged(sender As System.Object, e As System.EventArgs) Handles NumericUpDownQty.ValueChanged

        'If the user increases the QTY and it exceed the stock on hand, an error message is displayed. 
        Try
            Dim stock = TextBoxStock.Text
            stock = Convert.ToDouble(stock)
            If NumericUpDownQty.Value > stock Then
                MessageBox.Show("Quantity cannot Exceed the Maximum Stock on Hand", "Maximum Reached", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                NumericUpDownQty.Value = NumericUpDownQty.Value - 1
            End If

        Catch ex As Exception
        End Try
    End Sub

  
End Class