<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltHealthInvoices
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
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.lblTotalIncl = New System.Windows.Forms.Label()
        Me.lblTotalVat = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblTotalExcl = New System.Windows.Forms.Label()
        Me.DataGridViewInvoiceItems = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblInvPaidDate = New System.Windows.Forms.Label()
        Me.lblInvDate = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblClientEmail = New System.Windows.Forms.Label()
        Me.lblClientCell = New System.Windows.Forms.Label()
        Me.lblClientWork = New System.Windows.Forms.Label()
        Me.lblClientHome = New System.Windows.Forms.Label()
        Me.lblClientAddress = New System.Windows.Forms.Label()
        Me.lblClientID = New System.Windows.Forms.Label()
        Me.lblClientName = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBoxInvoiceNumber = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBoxInv.SuspendLayout()
        CType(Me.DataGridViewInvoiceItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(23, 572)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(142, 55)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'GroupBoxInv
        '
        Me.GroupBoxInv.Controls.Add(Me.btnPrint)
        Me.GroupBoxInv.Controls.Add(Me.lblTotalIncl)
        Me.GroupBoxInv.Controls.Add(Me.lblTotalVat)
        Me.GroupBoxInv.Controls.Add(Me.Label12)
        Me.GroupBoxInv.Controls.Add(Me.Label13)
        Me.GroupBoxInv.Controls.Add(Me.Label16)
        Me.GroupBoxInv.Controls.Add(Me.lblTotalExcl)
        Me.GroupBoxInv.Controls.Add(Me.DataGridViewInvoiceItems)
        Me.GroupBoxInv.Controls.Add(Me.PictureBox1)
        Me.GroupBoxInv.Controls.Add(Me.GroupBox2)
        Me.GroupBoxInv.Controls.Add(Me.GroupBox1)
        Me.GroupBoxInv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxInv.Location = New System.Drawing.Point(246, 66)
        Me.GroupBoxInv.Name = "GroupBoxInv"
        Me.GroupBoxInv.Size = New System.Drawing.Size(633, 561)
        Me.GroupBoxInv.TabIndex = 3
        Me.GroupBoxInv.TabStop = False
        '
        'btnPrint
        '
        Me.btnPrint.BackgroundImage = Global.AltHealth.My.Resources.Resources.print
        Me.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPrint.Location = New System.Drawing.Point(309, 493)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(37, 33)
        Me.btnPrint.TabIndex = 22
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'lblTotalIncl
        '
        Me.lblTotalIncl.AutoSize = True
        Me.lblTotalIncl.Enabled = False
        Me.lblTotalIncl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalIncl.Location = New System.Drawing.Point(514, 522)
        Me.lblTotalIncl.Name = "lblTotalIncl"
        Me.lblTotalIncl.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblTotalIncl.Size = New System.Drawing.Size(52, 20)
        Me.lblTotalIncl.TabIndex = 20
        Me.lblTotalIncl.Text = "R0.00"
        Me.lblTotalIncl.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTotalVat
        '
        Me.lblTotalVat.AutoSize = True
        Me.lblTotalVat.Enabled = False
        Me.lblTotalVat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalVat.Location = New System.Drawing.Point(514, 498)
        Me.lblTotalVat.Name = "lblTotalVat"
        Me.lblTotalVat.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblTotalVat.Size = New System.Drawing.Size(52, 20)
        Me.lblTotalVat.TabIndex = 19
        Me.lblTotalVat.Text = "R0.00"
        Me.lblTotalVat.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Enabled = False
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(390, 472)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label12.Size = New System.Drawing.Size(77, 20)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "Total Excl"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Enabled = False
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(390, 524)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label13.Size = New System.Drawing.Size(73, 20)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Total Incl"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Enabled = False
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(390, 498)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label16.Size = New System.Drawing.Size(96, 20)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "VAT @ 15%"
        '
        'lblTotalExcl
        '
        Me.lblTotalExcl.AutoSize = True
        Me.lblTotalExcl.Enabled = False
        Me.lblTotalExcl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalExcl.Location = New System.Drawing.Point(514, 472)
        Me.lblTotalExcl.Name = "lblTotalExcl"
        Me.lblTotalExcl.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblTotalExcl.Size = New System.Drawing.Size(52, 20)
        Me.lblTotalExcl.TabIndex = 8
        Me.lblTotalExcl.Text = "R0.00"
        Me.lblTotalExcl.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        Me.DataGridViewInvoiceItems.Enabled = False
        Me.DataGridViewInvoiceItems.Location = New System.Drawing.Point(22, 248)
        Me.DataGridViewInvoiceItems.Name = "DataGridViewInvoiceItems"
        Me.DataGridViewInvoiceItems.Size = New System.Drawing.Size(588, 210)
        Me.DataGridViewInvoiceItems.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = Global.AltHealth.My.Resources.Resources._61639303_Logo
        Me.PictureBox1.Location = New System.Drawing.Point(78, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(95, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblInvPaidDate)
        Me.GroupBox2.Controls.Add(Me.lblInvDate)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(22, 155)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(209, 84)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Invoice Information"
        '
        'lblInvPaidDate
        '
        Me.lblInvPaidDate.AutoSize = True
        Me.lblInvPaidDate.Location = New System.Drawing.Point(102, 55)
        Me.lblInvPaidDate.Name = "lblInvPaidDate"
        Me.lblInvPaidDate.Size = New System.Drawing.Size(66, 13)
        Me.lblInvPaidDate.TabIndex = 3
        Me.lblInvPaidDate.Text = "Invoice Paid"
        '
        'lblInvDate
        '
        Me.lblInvDate.AutoSize = True
        Me.lblInvDate.Location = New System.Drawing.Point(102, 37)
        Me.lblInvDate.Name = "lblInvDate"
        Me.lblInvDate.Size = New System.Drawing.Size(68, 13)
        Me.lblInvDate.TabIndex = 2
        Me.lblInvDate.Text = "Invoice Date"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(22, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Invoice Paid"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Invoice Date"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblClientEmail)
        Me.GroupBox1.Controls.Add(Me.lblClientCell)
        Me.GroupBox1.Controls.Add(Me.lblClientWork)
        Me.GroupBox1.Controls.Add(Me.lblClientHome)
        Me.GroupBox1.Controls.Add(Me.lblClientAddress)
        Me.GroupBox1.Controls.Add(Me.lblClientID)
        Me.GroupBox1.Controls.Add(Me.lblClientName)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(248, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(362, 209)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Client Information"
        '
        'lblClientEmail
        '
        Me.lblClientEmail.AutoSize = True
        Me.lblClientEmail.Location = New System.Drawing.Point(126, 186)
        Me.lblClientEmail.Name = "lblClientEmail"
        Me.lblClientEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblClientEmail.TabIndex = 15
        Me.lblClientEmail.Text = "Email"
        '
        'lblClientCell
        '
        Me.lblClientCell.AutoSize = True
        Me.lblClientCell.Location = New System.Drawing.Point(126, 165)
        Me.lblClientCell.Name = "lblClientCell"
        Me.lblClientCell.Size = New System.Drawing.Size(53, 13)
        Me.lblClientCell.TabIndex = 14
        Me.lblClientCell.Text = "Client Cell"
        '
        'lblClientWork
        '
        Me.lblClientWork.AutoSize = True
        Me.lblClientWork.Location = New System.Drawing.Point(126, 144)
        Me.lblClientWork.Name = "lblClientWork"
        Me.lblClientWork.Size = New System.Drawing.Size(62, 13)
        Me.lblClientWork.TabIndex = 13
        Me.lblClientWork.Text = "Client Work"
        '
        'lblClientHome
        '
        Me.lblClientHome.AutoSize = True
        Me.lblClientHome.Location = New System.Drawing.Point(126, 123)
        Me.lblClientHome.Name = "lblClientHome"
        Me.lblClientHome.Size = New System.Drawing.Size(64, 13)
        Me.lblClientHome.TabIndex = 12
        Me.lblClientHome.Text = "Client Home"
        '
        'lblClientAddress
        '
        Me.lblClientAddress.Location = New System.Drawing.Point(126, 74)
        Me.lblClientAddress.Name = "lblClientAddress"
        Me.lblClientAddress.Size = New System.Drawing.Size(226, 42)
        Me.lblClientAddress.TabIndex = 11
        Me.lblClientAddress.Text = "Client Address"
        '
        'lblClientID
        '
        Me.lblClientID.AutoSize = True
        Me.lblClientID.Location = New System.Drawing.Point(126, 32)
        Me.lblClientID.Name = "lblClientID"
        Me.lblClientID.Size = New System.Drawing.Size(47, 13)
        Me.lblClientID.TabIndex = 9
        Me.lblClientID.Text = "Client ID"
        '
        'lblClientName
        '
        Me.lblClientName.AutoSize = True
        Me.lblClientName.Location = New System.Drawing.Point(126, 53)
        Me.lblClientName.Name = "lblClientName"
        Me.lblClientName.Size = New System.Drawing.Size(64, 13)
        Me.lblClientName.TabIndex = 10
        Me.lblClientName.Text = "Client Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 186)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Email"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 165)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Client Cell"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Client Work"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Client Home"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Client Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Client ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Client Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Location = New System.Drawing.Point(471, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 54)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Invoices"
        '
        'txtBoxInvoiceNumber
        '
        Me.txtBoxInvoiceNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxInvoiceNumber.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtBoxInvoiceNumber.Location = New System.Drawing.Point(42, 229)
        Me.txtBoxInvoiceNumber.Mask = "INV99999"
        Me.txtBoxInvoiceNumber.Name = "txtBoxInvoiceNumber"
        Me.txtBoxInvoiceNumber.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtBoxInvoiceNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtBoxInvoiceNumber.Size = New System.Drawing.Size(106, 31)
        Me.txtBoxInvoiceNumber.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(33, 261)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(126, 44)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Insert Invoice number and press Enter"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AltHealthInvoices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AltHealth.My.Resources.Resources._61639303_Logo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(891, 647)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtBoxInvoiceNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBoxInv)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AltHealthInvoices"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AltHealth Invoices"
        Me.GroupBoxInv.ResumeLayout(False)
        Me.GroupBoxInv.PerformLayout()
        CType(Me.DataGridViewInvoiceItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents GroupBoxInv As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblInvPaidDate As System.Windows.Forms.Label
    Friend WithEvents lblInvDate As System.Windows.Forms.Label
    Friend WithEvents lblClientEmail As System.Windows.Forms.Label
    Friend WithEvents lblClientCell As System.Windows.Forms.Label
    Friend WithEvents lblClientWork As System.Windows.Forms.Label
    Friend WithEvents lblClientHome As System.Windows.Forms.Label
    Friend WithEvents lblClientAddress As System.Windows.Forms.Label
    Friend WithEvents lblClientID As System.Windows.Forms.Label
    Friend WithEvents lblClientName As System.Windows.Forms.Label
    Friend WithEvents txtBoxInvoiceNumber As System.Windows.Forms.MaskedTextBox
    Friend WithEvents DataGridViewInvoiceItems As System.Windows.Forms.DataGridView
    Friend WithEvents lblTotalExcl As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblTotalIncl As System.Windows.Forms.Label
    Friend WithEvents lblTotalVat As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
End Class
