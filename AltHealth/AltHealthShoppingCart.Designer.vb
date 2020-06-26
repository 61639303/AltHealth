<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltHealthShoppingCart
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBoxInv = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxPaid = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotalInvoice = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblTotalInvoiceExVat = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblTotalVat = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridViewInvoiceItems = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ComboBoxSupplementID = New System.Windows.Forms.ComboBox()
        Me.NumericUpDownQty = New System.Windows.Forms.NumericUpDown()
        Me.TextBoxExcl = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBoxStock = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBoxDescription = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblInvDate = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBoxClientID = New System.Windows.Forms.ComboBox()
        Me.lblClientEmail = New System.Windows.Forms.Label()
        Me.lblClientCell = New System.Windows.Forms.Label()
        Me.lblClientWork = New System.Windows.Forms.Label()
        Me.lblClientHome = New System.Windows.Forms.Label()
        Me.lblClientAddress = New System.Windows.Forms.Label()
        Me.lblClientName = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBoxInv.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridViewInvoiceItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.NumericUpDownQty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(23, 572)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(142, 55)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'GroupBoxInv
        '
        Me.GroupBoxInv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBoxInv.Controls.Add(Me.GroupBox4)
        Me.GroupBoxInv.Controls.Add(Me.btnPrint)
        Me.GroupBoxInv.Controls.Add(Me.btnDelete)
        Me.GroupBoxInv.Controls.Add(Me.btnAdd)
        Me.GroupBoxInv.Controls.Add(Me.GroupBox2)
        Me.GroupBoxInv.Controls.Add(Me.GroupBox3)
        Me.GroupBoxInv.Controls.Add(Me.lblInvDate)
        Me.GroupBoxInv.Controls.Add(Me.GroupBox1)
        Me.GroupBoxInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxInv.Location = New System.Drawing.Point(246, 6)
        Me.GroupBoxInv.Name = "GroupBoxInv"
        Me.GroupBoxInv.Size = New System.Drawing.Size(633, 621)
        Me.GroupBoxInv.TabIndex = 4
        Me.GroupBoxInv.TabStop = False
        Me.GroupBoxInv.Text = "Add Items"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CheckBoxPaid)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.lblTotalInvoice)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.lblTotalInvoiceExVat)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.lblTotalVat)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(22, 503)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(527, 95)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Totals"
        '
        'CheckBoxPaid
        '
        Me.CheckBoxPaid.AutoSize = True
        Me.CheckBoxPaid.Location = New System.Drawing.Point(84, 40)
        Me.CheckBoxPaid.Name = "CheckBoxPaid"
        Me.CheckBoxPaid.Size = New System.Drawing.Size(85, 17)
        Me.CheckBoxPaid.TabIndex = 16
        Me.CheckBoxPaid.Text = "Invoice Paid"
        Me.CheckBoxPaid.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(300, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(77, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Total Excl"
        '
        'lblTotalInvoice
        '
        Me.lblTotalInvoice.AutoSize = True
        Me.lblTotalInvoice.Enabled = False
        Me.lblTotalInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalInvoice.Location = New System.Drawing.Point(421, 63)
        Me.lblTotalInvoice.Name = "lblTotalInvoice"
        Me.lblTotalInvoice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblTotalInvoice.Size = New System.Drawing.Size(52, 20)
        Me.lblTotalInvoice.TabIndex = 8
        Me.lblTotalInvoice.Text = "R0.00"
        Me.lblTotalInvoice.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Enabled = False
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(300, 63)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label12.Size = New System.Drawing.Size(73, 20)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Total Incl"
        '
        'lblTotalInvoiceExVat
        '
        Me.lblTotalInvoiceExVat.AutoSize = True
        Me.lblTotalInvoiceExVat.Enabled = False
        Me.lblTotalInvoiceExVat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalInvoiceExVat.Location = New System.Drawing.Point(421, 11)
        Me.lblTotalInvoiceExVat.Name = "lblTotalInvoiceExVat"
        Me.lblTotalInvoiceExVat.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblTotalInvoiceExVat.Size = New System.Drawing.Size(52, 20)
        Me.lblTotalInvoiceExVat.TabIndex = 12
        Me.lblTotalInvoiceExVat.Text = "R0.00"
        Me.lblTotalInvoiceExVat.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Enabled = False
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(300, 37)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label16.Size = New System.Drawing.Size(96, 20)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "VAT @ 15%"
        '
        'lblTotalVat
        '
        Me.lblTotalVat.AutoSize = True
        Me.lblTotalVat.Enabled = False
        Me.lblTotalVat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalVat.Location = New System.Drawing.Point(421, 37)
        Me.lblTotalVat.Name = "lblTotalVat"
        Me.lblTotalVat.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblTotalVat.Size = New System.Drawing.Size(52, 20)
        Me.lblTotalVat.TabIndex = 14
        Me.lblTotalVat.Text = "R0.00"
        Me.lblTotalVat.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnPrint
        '
        Me.btnPrint.BackgroundImage = Global.AltHealth.My.Resources.Resources.print
        Me.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPrint.Location = New System.Drawing.Point(573, 538)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(37, 33)
        Me.btnPrint.TabIndex = 16
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.BackgroundImage = Global.AltHealth.My.Resources.Resources.delete
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDelete.Location = New System.Drawing.Point(573, 409)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(37, 33)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.BackgroundImage = Global.AltHealth.My.Resources.Resources.Add
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAdd.Location = New System.Drawing.Point(573, 289)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(37, 33)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridViewInvoiceItems)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(22, 350)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(527, 146)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cart Items"
        '
        'DataGridViewInvoiceItems
        '
        Me.DataGridViewInvoiceItems.AllowUserToAddRows = False
        Me.DataGridViewInvoiceItems.AllowUserToDeleteRows = False
        Me.DataGridViewInvoiceItems.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewInvoiceItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewInvoiceItems.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridViewInvoiceItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridViewInvoiceItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DataGridViewInvoiceItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewInvoiceItems.Location = New System.Drawing.Point(13, 30)
        Me.DataGridViewInvoiceItems.Name = "DataGridViewInvoiceItems"
        Me.DataGridViewInvoiceItems.Size = New System.Drawing.Size(499, 98)
        Me.DataGridViewInvoiceItems.TabIndex = 7
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ComboBoxSupplementID)
        Me.GroupBox3.Controls.Add(Me.NumericUpDownQty)
        Me.GroupBox3.Controls.Add(Me.TextBoxExcl)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.TextBoxStock)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.TextBoxDescription)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(22, 255)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(527, 88)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Add Item to Cart"
        '
        'ComboBoxSupplementID
        '
        Me.ComboBoxSupplementID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSupplementID.FormattingEnabled = True
        Me.ComboBoxSupplementID.Location = New System.Drawing.Point(16, 47)
        Me.ComboBoxSupplementID.Name = "ComboBoxSupplementID"
        Me.ComboBoxSupplementID.Size = New System.Drawing.Size(114, 21)
        Me.ComboBoxSupplementID.TabIndex = 10
        '
        'NumericUpDownQty
        '
        Me.NumericUpDownQty.Location = New System.Drawing.Point(477, 47)
        Me.NumericUpDownQty.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownQty.Name = "NumericUpDownQty"
        Me.NumericUpDownQty.Size = New System.Drawing.Size(42, 20)
        Me.NumericUpDownQty.TabIndex = 9
        Me.NumericUpDownQty.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'TextBoxExcl
        '
        Me.TextBoxExcl.Enabled = False
        Me.TextBoxExcl.Location = New System.Drawing.Point(397, 47)
        Me.TextBoxExcl.Name = "TextBoxExcl"
        Me.TextBoxExcl.Size = New System.Drawing.Size(60, 20)
        Me.TextBoxExcl.TabIndex = 8
        Me.TextBoxExcl.Text = "0.00"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(479, 27)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(23, 13)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Qty"
        '
        'TextBoxStock
        '
        Me.TextBoxStock.Enabled = False
        Me.TextBoxStock.Location = New System.Drawing.Point(341, 47)
        Me.TextBoxStock.Name = "TextBoxStock"
        Me.TextBoxStock.Size = New System.Drawing.Size(44, 20)
        Me.TextBoxStock.TabIndex = 7
        Me.TextBoxStock.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(341, 27)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(47, 13)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "In Stock"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(394, 27)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 13)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Price Excl"
        '
        'TextBoxDescription
        '
        Me.TextBoxDescription.Enabled = False
        Me.TextBoxDescription.Location = New System.Drawing.Point(136, 47)
        Me.TextBoxDescription.Name = "TextBoxDescription"
        Me.TextBoxDescription.Size = New System.Drawing.Size(194, 20)
        Me.TextBoxDescription.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(133, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Description"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Supplement ID"
        '
        'lblInvDate
        '
        Me.lblInvDate.AutoSize = True
        Me.lblInvDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvDate.Location = New System.Drawing.Point(523, 40)
        Me.lblInvDate.Name = "lblInvDate"
        Me.lblInvDate.Size = New System.Drawing.Size(83, 16)
        Me.lblInvDate.TabIndex = 2
        Me.lblInvDate.Text = "Invoice Date"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBoxClientID)
        Me.GroupBox1.Controls.Add(Me.lblClientEmail)
        Me.GroupBox1.Controls.Add(Me.lblClientCell)
        Me.GroupBox1.Controls.Add(Me.lblClientWork)
        Me.GroupBox1.Controls.Add(Me.lblClientHome)
        Me.GroupBox1.Controls.Add(Me.lblClientAddress)
        Me.GroupBox1.Controls.Add(Me.lblClientName)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(22, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(588, 179)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Client Information"
        '
        'ComboBoxClientID
        '
        Me.ComboBoxClientID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxClientID.FormattingEnabled = True
        Me.ComboBoxClientID.Location = New System.Drawing.Point(119, 25)
        Me.ComboBoxClientID.Name = "ComboBoxClientID"
        Me.ComboBoxClientID.Size = New System.Drawing.Size(149, 21)
        Me.ComboBoxClientID.TabIndex = 16
        '
        'lblClientEmail
        '
        Me.lblClientEmail.AutoSize = True
        Me.lblClientEmail.Location = New System.Drawing.Point(116, 156)
        Me.lblClientEmail.Name = "lblClientEmail"
        Me.lblClientEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblClientEmail.TabIndex = 15
        Me.lblClientEmail.Text = "Email"
        '
        'lblClientCell
        '
        Me.lblClientCell.AutoSize = True
        Me.lblClientCell.Location = New System.Drawing.Point(116, 135)
        Me.lblClientCell.Name = "lblClientCell"
        Me.lblClientCell.Size = New System.Drawing.Size(53, 13)
        Me.lblClientCell.TabIndex = 14
        Me.lblClientCell.Text = "Client Cell"
        '
        'lblClientWork
        '
        Me.lblClientWork.AutoSize = True
        Me.lblClientWork.Location = New System.Drawing.Point(116, 114)
        Me.lblClientWork.Name = "lblClientWork"
        Me.lblClientWork.Size = New System.Drawing.Size(62, 13)
        Me.lblClientWork.TabIndex = 13
        Me.lblClientWork.Text = "Client Work"
        '
        'lblClientHome
        '
        Me.lblClientHome.AutoSize = True
        Me.lblClientHome.Location = New System.Drawing.Point(116, 93)
        Me.lblClientHome.Name = "lblClientHome"
        Me.lblClientHome.Size = New System.Drawing.Size(64, 13)
        Me.lblClientHome.TabIndex = 12
        Me.lblClientHome.Text = "Client Home"
        '
        'lblClientAddress
        '
        Me.lblClientAddress.Location = New System.Drawing.Point(116, 74)
        Me.lblClientAddress.Name = "lblClientAddress"
        Me.lblClientAddress.Size = New System.Drawing.Size(443, 25)
        Me.lblClientAddress.TabIndex = 11
        Me.lblClientAddress.Text = "Client Address"
        '
        'lblClientName
        '
        Me.lblClientName.AutoSize = True
        Me.lblClientName.Location = New System.Drawing.Point(116, 53)
        Me.lblClientName.Name = "lblClientName"
        Me.lblClientName.Size = New System.Drawing.Size(64, 13)
        Me.lblClientName.TabIndex = 10
        Me.lblClientName.Text = "Client Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 156)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Email"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 135)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Client Cell"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 114)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Client Work"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Client Home"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Client Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Client ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Client Name"
        '
        'AltHealthShoppingCart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AltHealth.My.Resources.Resources._61639303_Logo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(891, 647)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBoxInv)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AltHealthShoppingCart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AltHealth Shopping Cart"
        Me.GroupBoxInv.ResumeLayout(False)
        Me.GroupBoxInv.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridViewInvoiceItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.NumericUpDownQty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents GroupBoxInv As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblTotalInvoice As System.Windows.Forms.Label
    Friend WithEvents DataGridViewInvoiceItems As System.Windows.Forms.DataGridView
    Friend WithEvents lblInvDate As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblClientEmail As System.Windows.Forms.Label
    Friend WithEvents lblClientCell As System.Windows.Forms.Label
    Friend WithEvents lblClientWork As System.Windows.Forms.Label
    Friend WithEvents lblClientHome As System.Windows.Forms.Label
    Friend WithEvents lblClientAddress As System.Windows.Forms.Label
    Friend WithEvents lblClientName As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents NumericUpDownQty As System.Windows.Forms.NumericUpDown
    Friend WithEvents TextBoxExcl As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxStock As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBoxDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxSupplementID As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblTotalVat As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTotalInvoiceExVat As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBoxClientID As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBoxPaid As System.Windows.Forms.CheckBox
End Class
