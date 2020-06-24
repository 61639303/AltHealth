<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltHealthSupplementInfoAdd
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBoxSupplierID = New System.Windows.Forms.ComboBox()
        Me.TextBoxNapppi = New System.Windows.Forms.TextBox()
        Me.TextBoxMinLvl = New System.Windows.Forms.TextBox()
        Me.TextBoxCostInc = New System.Windows.Forms.TextBox()
        Me.TextBoxCurLvl = New System.Windows.Forms.TextBox()
        Me.TextBoxCostEx = New System.Windows.Forms.TextBox()
        Me.TextBoxDesc = New System.Windows.Forms.TextBox()
        Me.TextBoxSupplementID = New System.Windows.Forms.TextBox()
        Me.lblSupplierID = New System.Windows.Forms.Label()
        Me.lblNappi = New System.Windows.Forms.Label()
        Me.lblCur = New System.Windows.Forms.Label()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.lblCostInc = New System.Windows.Forms.Label()
        Me.lblCostEx = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lblSupplementID = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBoxSupplierID)
        Me.GroupBox1.Controls.Add(Me.TextBoxNapppi)
        Me.GroupBox1.Controls.Add(Me.TextBoxMinLvl)
        Me.GroupBox1.Controls.Add(Me.TextBoxCostInc)
        Me.GroupBox1.Controls.Add(Me.TextBoxCurLvl)
        Me.GroupBox1.Controls.Add(Me.TextBoxCostEx)
        Me.GroupBox1.Controls.Add(Me.TextBoxDesc)
        Me.GroupBox1.Controls.Add(Me.TextBoxSupplementID)
        Me.GroupBox1.Controls.Add(Me.lblSupplierID)
        Me.GroupBox1.Controls.Add(Me.lblNappi)
        Me.GroupBox1.Controls.Add(Me.lblCur)
        Me.GroupBox1.Controls.Add(Me.lblMin)
        Me.GroupBox1.Controls.Add(Me.lblCostInc)
        Me.GroupBox1.Controls.Add(Me.lblCostEx)
        Me.GroupBox1.Controls.Add(Me.lblDesc)
        Me.GroupBox1.Controls.Add(Me.lblSupplementID)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(36, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(401, 333)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Supplement Information"
        '
        'ComboBoxSupplierID
        '
        Me.ComboBoxSupplierID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxSupplierID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxSupplierID.FormattingEnabled = True
        Me.ComboBoxSupplierID.Location = New System.Drawing.Point(168, 290)
        Me.ComboBoxSupplierID.Name = "ComboBoxSupplierID"
        Me.ComboBoxSupplierID.Size = New System.Drawing.Size(203, 21)
        Me.ComboBoxSupplierID.TabIndex = 7
        '
        'TextBoxNapppi
        '
        Me.TextBoxNapppi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNapppi.Location = New System.Drawing.Point(167, 252)
        Me.TextBoxNapppi.Name = "TextBoxNapppi"
        Me.TextBoxNapppi.Size = New System.Drawing.Size(204, 20)
        Me.TextBoxNapppi.TabIndex = 6
        '
        'TextBoxMinLvl
        '
        Me.TextBoxMinLvl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxMinLvl.Location = New System.Drawing.Point(167, 182)
        Me.TextBoxMinLvl.Name = "TextBoxMinLvl"
        Me.TextBoxMinLvl.Size = New System.Drawing.Size(204, 20)
        Me.TextBoxMinLvl.TabIndex = 4
        Me.TextBoxMinLvl.Text = "0"
        '
        'TextBoxCostInc
        '
        Me.TextBoxCostInc.Enabled = False
        Me.TextBoxCostInc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCostInc.Location = New System.Drawing.Point(167, 147)
        Me.TextBoxCostInc.Name = "TextBoxCostInc"
        Me.TextBoxCostInc.Size = New System.Drawing.Size(204, 20)
        Me.TextBoxCostInc.TabIndex = 11
        Me.TextBoxCostInc.Text = "0.00"
        '
        'TextBoxCurLvl
        '
        Me.TextBoxCurLvl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCurLvl.Location = New System.Drawing.Point(167, 217)
        Me.TextBoxCurLvl.Name = "TextBoxCurLvl"
        Me.TextBoxCurLvl.Size = New System.Drawing.Size(204, 20)
        Me.TextBoxCurLvl.TabIndex = 5
        Me.TextBoxCurLvl.Text = "0"
        '
        'TextBoxCostEx
        '
        Me.TextBoxCostEx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCostEx.Location = New System.Drawing.Point(167, 107)
        Me.TextBoxCostEx.Name = "TextBoxCostEx"
        Me.TextBoxCostEx.Size = New System.Drawing.Size(204, 20)
        Me.TextBoxCostEx.TabIndex = 3
        Me.TextBoxCostEx.Text = "0.00"
        '
        'TextBoxDesc
        '
        Me.TextBoxDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDesc.Location = New System.Drawing.Point(167, 76)
        Me.TextBoxDesc.MaxLength = 40
        Me.TextBoxDesc.Name = "TextBoxDesc"
        Me.TextBoxDesc.Size = New System.Drawing.Size(204, 20)
        Me.TextBoxDesc.TabIndex = 2
        '
        'TextBoxSupplementID
        '
        Me.TextBoxSupplementID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSupplementID.Location = New System.Drawing.Point(167, 39)
        Me.TextBoxSupplementID.MaxLength = 20
        Me.TextBoxSupplementID.Name = "TextBoxSupplementID"
        Me.TextBoxSupplementID.Size = New System.Drawing.Size(204, 20)
        Me.TextBoxSupplementID.TabIndex = 1
        '
        'lblSupplierID
        '
        Me.lblSupplierID.AutoSize = True
        Me.lblSupplierID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupplierID.Location = New System.Drawing.Point(23, 290)
        Me.lblSupplierID.Name = "lblSupplierID"
        Me.lblSupplierID.Size = New System.Drawing.Size(59, 13)
        Me.lblSupplierID.TabIndex = 7
        Me.lblSupplierID.Text = "Supplier ID"
        '
        'lblNappi
        '
        Me.lblNappi.AutoSize = True
        Me.lblNappi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNappi.Location = New System.Drawing.Point(23, 252)
        Me.lblNappi.Name = "lblNappi"
        Me.lblNappi.Size = New System.Drawing.Size(63, 13)
        Me.lblNappi.TabIndex = 6
        Me.lblNappi.Text = "Nappi Code"
        '
        'lblCur
        '
        Me.lblCur.AutoSize = True
        Me.lblCur.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCur.Location = New System.Drawing.Point(23, 217)
        Me.lblCur.Name = "lblCur"
        Me.lblCur.Size = New System.Drawing.Size(101, 13)
        Me.lblCur.TabIndex = 5
        Me.lblCur.Text = "Current Stock Level"
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMin.Location = New System.Drawing.Point(23, 182)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(113, 13)
        Me.lblMin.TabIndex = 4
        Me.lblMin.Text = "Minimum Stock Levels"
        '
        'lblCostInc
        '
        Me.lblCostInc.AutoSize = True
        Me.lblCostInc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostInc.Location = New System.Drawing.Point(23, 147)
        Me.lblCostInc.Name = "lblCostInc"
        Me.lblCostInc.Size = New System.Drawing.Size(74, 13)
        Me.lblCostInc.TabIndex = 3
        Me.lblCostInc.Text = "Cost Including"
        '
        'lblCostEx
        '
        Me.lblCostEx.AutoSize = True
        Me.lblCostEx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostEx.Location = New System.Drawing.Point(23, 107)
        Me.lblCostEx.Name = "lblCostEx"
        Me.lblCostEx.Size = New System.Drawing.Size(77, 13)
        Me.lblCostEx.TabIndex = 2
        Me.lblCostEx.Text = "Cost Excluding"
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(23, 76)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(60, 13)
        Me.lblDesc.TabIndex = 1
        Me.lblDesc.Text = "Description"
        '
        'lblSupplementID
        '
        Me.lblSupplementID.AutoSize = True
        Me.lblSupplementID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupplementID.Location = New System.Drawing.Point(23, 39)
        Me.lblSupplementID.Name = "lblSupplementID"
        Me.lblSupplementID.Size = New System.Drawing.Size(77, 13)
        Me.lblSupplementID.TabIndex = 0
        Me.lblSupplementID.Text = "Supplement ID"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(156, 374)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(86, 42)
        Me.btnOK.TabIndex = 8
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(248, 374)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(86, 42)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'AltHealthSupplementInfoAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 427)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AltHealthSupplementInfoAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AltHealth Add New Supplement"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblSupplierID As System.Windows.Forms.Label
    Friend WithEvents lblNappi As System.Windows.Forms.Label
    Friend WithEvents lblCur As System.Windows.Forms.Label
    Friend WithEvents lblMin As System.Windows.Forms.Label
    Friend WithEvents lblCostInc As System.Windows.Forms.Label
    Friend WithEvents lblCostEx As System.Windows.Forms.Label
    Friend WithEvents lblDesc As System.Windows.Forms.Label
    Friend WithEvents lblSupplementID As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents TextBoxSupplementID As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNapppi As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxMinLvl As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCostInc As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCurLvl As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCostEx As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDesc As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxSupplierID As System.Windows.Forms.ComboBox
End Class
