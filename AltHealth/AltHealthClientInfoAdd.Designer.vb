<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltHealthClientInfoAdd
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
        Me.GroupBoxClientInfo = New System.Windows.Forms.GroupBox()
        Me.TextBoxCell = New System.Windows.Forms.MaskedTextBox()
        Me.TextBoxWork = New System.Windows.Forms.MaskedTextBox()
        Me.TextBoxHome = New System.Windows.Forms.MaskedTextBox()
        Me.ComboBoxReference = New System.Windows.Forms.ComboBox()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.TextBoxCode = New System.Windows.Forms.TextBox()
        Me.TextBoxAddress = New System.Windows.Forms.TextBox()
        Me.TextBoxSurname = New System.Windows.Forms.TextBox()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.TextBoxClientID = New System.Windows.Forms.TextBox()
        Me.lblClientID = New System.Windows.Forms.Label()
        Me.lblReference = New System.Windows.Forms.Label()
        Me.lblClientName = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblSurnme = New System.Windows.Forms.Label()
        Me.lblCell = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblWork = New System.Windows.Forms.Label()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.lblHome = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.GroupBoxClientInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxClientInfo
        '
        Me.GroupBoxClientInfo.Controls.Add(Me.TextBoxCell)
        Me.GroupBoxClientInfo.Controls.Add(Me.TextBoxWork)
        Me.GroupBoxClientInfo.Controls.Add(Me.TextBoxHome)
        Me.GroupBoxClientInfo.Controls.Add(Me.ComboBoxReference)
        Me.GroupBoxClientInfo.Controls.Add(Me.TextBoxEmail)
        Me.GroupBoxClientInfo.Controls.Add(Me.TextBoxCode)
        Me.GroupBoxClientInfo.Controls.Add(Me.TextBoxAddress)
        Me.GroupBoxClientInfo.Controls.Add(Me.TextBoxSurname)
        Me.GroupBoxClientInfo.Controls.Add(Me.TextBoxName)
        Me.GroupBoxClientInfo.Controls.Add(Me.TextBoxClientID)
        Me.GroupBoxClientInfo.Controls.Add(Me.lblClientID)
        Me.GroupBoxClientInfo.Controls.Add(Me.lblReference)
        Me.GroupBoxClientInfo.Controls.Add(Me.lblClientName)
        Me.GroupBoxClientInfo.Controls.Add(Me.lblEmail)
        Me.GroupBoxClientInfo.Controls.Add(Me.lblSurnme)
        Me.GroupBoxClientInfo.Controls.Add(Me.lblCell)
        Me.GroupBoxClientInfo.Controls.Add(Me.lblAddress)
        Me.GroupBoxClientInfo.Controls.Add(Me.lblWork)
        Me.GroupBoxClientInfo.Controls.Add(Me.lblCode)
        Me.GroupBoxClientInfo.Controls.Add(Me.lblHome)
        Me.GroupBoxClientInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxClientInfo.Location = New System.Drawing.Point(36, 25)
        Me.GroupBoxClientInfo.Name = "GroupBoxClientInfo"
        Me.GroupBoxClientInfo.Size = New System.Drawing.Size(401, 402)
        Me.GroupBoxClientInfo.TabIndex = 11
        Me.GroupBoxClientInfo.TabStop = False
        Me.GroupBoxClientInfo.Text = "Client Information"
        '
        'TextBoxCell
        '
        Me.TextBoxCell.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCell.Location = New System.Drawing.Point(145, 282)
        Me.TextBoxCell.Mask = "(999)-(999)-(999)"
        Me.TextBoxCell.Name = "TextBoxCell"
        Me.TextBoxCell.Size = New System.Drawing.Size(231, 20)
        Me.TextBoxCell.TabIndex = 22
        '
        'TextBoxWork
        '
        Me.TextBoxWork.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxWork.Location = New System.Drawing.Point(145, 246)
        Me.TextBoxWork.Mask = "(999)-(999)-(999)"
        Me.TextBoxWork.Name = "TextBoxWork"
        Me.TextBoxWork.Size = New System.Drawing.Size(231, 20)
        Me.TextBoxWork.TabIndex = 21
        '
        'TextBoxHome
        '
        Me.TextBoxHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxHome.Location = New System.Drawing.Point(145, 209)
        Me.TextBoxHome.Mask = "(999)-(999)-(999)"
        Me.TextBoxHome.Name = "TextBoxHome"
        Me.TextBoxHome.Size = New System.Drawing.Size(231, 20)
        Me.TextBoxHome.TabIndex = 20
        '
        'ComboBoxReference
        '
        Me.ComboBoxReference.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxReference.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxReference.FormattingEnabled = True
        Me.ComboBoxReference.Location = New System.Drawing.Point(145, 352)
        Me.ComboBoxReference.Name = "ComboBoxReference"
        Me.ComboBoxReference.Size = New System.Drawing.Size(109, 21)
        Me.ComboBoxReference.TabIndex = 19
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEmail.Location = New System.Drawing.Point(145, 318)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(231, 20)
        Me.TextBoxEmail.TabIndex = 18
        '
        'TextBoxCode
        '
        Me.TextBoxCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCode.Location = New System.Drawing.Point(145, 174)
        Me.TextBoxCode.Name = "TextBoxCode"
        Me.TextBoxCode.Size = New System.Drawing.Size(231, 20)
        Me.TextBoxCode.TabIndex = 14
        '
        'TextBoxAddress
        '
        Me.TextBoxAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAddress.Location = New System.Drawing.Point(145, 138)
        Me.TextBoxAddress.Name = "TextBoxAddress"
        Me.TextBoxAddress.Size = New System.Drawing.Size(231, 20)
        Me.TextBoxAddress.TabIndex = 13
        '
        'TextBoxSurname
        '
        Me.TextBoxSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSurname.Location = New System.Drawing.Point(145, 102)
        Me.TextBoxSurname.Name = "TextBoxSurname"
        Me.TextBoxSurname.Size = New System.Drawing.Size(231, 20)
        Me.TextBoxSurname.TabIndex = 12
        '
        'TextBoxName
        '
        Me.TextBoxName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxName.Location = New System.Drawing.Point(145, 66)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(231, 20)
        Me.TextBoxName.TabIndex = 11
        '
        'TextBoxClientID
        '
        Me.TextBoxClientID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxClientID.Location = New System.Drawing.Point(145, 30)
        Me.TextBoxClientID.Name = "TextBoxClientID"
        Me.TextBoxClientID.Size = New System.Drawing.Size(231, 20)
        Me.TextBoxClientID.TabIndex = 10
        '
        'lblClientID
        '
        Me.lblClientID.AutoSize = True
        Me.lblClientID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientID.Location = New System.Drawing.Point(16, 37)
        Me.lblClientID.Name = "lblClientID"
        Me.lblClientID.Size = New System.Drawing.Size(47, 13)
        Me.lblClientID.TabIndex = 0
        Me.lblClientID.Text = "Client ID"
        '
        'lblReference
        '
        Me.lblReference.AutoSize = True
        Me.lblReference.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReference.Location = New System.Drawing.Point(16, 361)
        Me.lblReference.Name = "lblReference"
        Me.lblReference.Size = New System.Drawing.Size(57, 13)
        Me.lblReference.TabIndex = 9
        Me.lblReference.Text = "Reference"
        '
        'lblClientName
        '
        Me.lblClientName.AutoSize = True
        Me.lblClientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientName.Location = New System.Drawing.Point(16, 73)
        Me.lblClientName.Name = "lblClientName"
        Me.lblClientName.Size = New System.Drawing.Size(35, 13)
        Me.lblClientName.TabIndex = 1
        Me.lblClientName.Text = "Name"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(16, 325)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 8
        Me.lblEmail.Text = "Email"
        '
        'lblSurnme
        '
        Me.lblSurnme.AutoSize = True
        Me.lblSurnme.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurnme.Location = New System.Drawing.Point(16, 109)
        Me.lblSurnme.Name = "lblSurnme"
        Me.lblSurnme.Size = New System.Drawing.Size(49, 13)
        Me.lblSurnme.TabIndex = 2
        Me.lblSurnme.Text = "Surname"
        '
        'lblCell
        '
        Me.lblCell.AutoSize = True
        Me.lblCell.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCell.Location = New System.Drawing.Point(16, 289)
        Me.lblCell.Name = "lblCell"
        Me.lblCell.Size = New System.Drawing.Size(58, 13)
        Me.lblCell.TabIndex = 7
        Me.lblCell.Text = "Cell Phone"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(16, 145)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(45, 13)
        Me.lblAddress.TabIndex = 3
        Me.lblAddress.Text = "Address"
        '
        'lblWork
        '
        Me.lblWork.AutoSize = True
        Me.lblWork.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWork.Location = New System.Drawing.Point(16, 253)
        Me.lblWork.Name = "lblWork"
        Me.lblWork.Size = New System.Drawing.Size(67, 13)
        Me.lblWork.TabIndex = 6
        Me.lblWork.Text = "Work Phone"
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(16, 181)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(64, 13)
        Me.lblCode.TabIndex = 4
        Me.lblCode.Text = "Postal Code"
        '
        'lblHome
        '
        Me.lblHome.AutoSize = True
        Me.lblHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHome.Location = New System.Drawing.Point(16, 217)
        Me.lblHome.Name = "lblHome"
        Me.lblHome.Size = New System.Drawing.Size(69, 13)
        Me.lblHome.TabIndex = 5
        Me.lblHome.Text = "Home Phone"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(248, 433)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(86, 42)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(156, 433)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(86, 42)
        Me.btnOK.TabIndex = 13
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'AltHealthClientInfoAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 487)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GroupBoxClientInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AltHealthClientInfoAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AltHealth Add New Client"
        Me.GroupBoxClientInfo.ResumeLayout(False)
        Me.GroupBoxClientInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxClientInfo As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxEmail As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCode As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxAddress As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSurname As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxClientID As System.Windows.Forms.TextBox
    Friend WithEvents lblClientID As System.Windows.Forms.Label
    Friend WithEvents lblReference As System.Windows.Forms.Label
    Friend WithEvents lblClientName As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblSurnme As System.Windows.Forms.Label
    Friend WithEvents lblCell As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblWork As System.Windows.Forms.Label
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents lblHome As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents ComboBoxReference As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxHome As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TextBoxCell As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TextBoxWork As System.Windows.Forms.MaskedTextBox
End Class
