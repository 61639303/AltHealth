<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltHealthClientInfoDisplay
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
        Me.lblClientID = New System.Windows.Forms.Label()
        Me.lblClientName = New System.Windows.Forms.Label()
        Me.lblSurnme = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.lblHome = New System.Windows.Forms.Label()
        Me.lblWork = New System.Windows.Forms.Label()
        Me.lblCell = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblReference = New System.Windows.Forms.Label()
        Me.GroupBoxClientInfo = New System.Windows.Forms.GroupBox()
        Me.TextBoxReference = New System.Windows.Forms.TextBox()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.TextBoxCell = New System.Windows.Forms.TextBox()
        Me.TextBoxWork = New System.Windows.Forms.TextBox()
        Me.TextBoxHome = New System.Windows.Forms.TextBox()
        Me.TextBoxCode = New System.Windows.Forms.TextBox()
        Me.TextBoxAddress = New System.Windows.Forms.TextBox()
        Me.TextBoxSurname = New System.Windows.Forms.TextBox()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.TextBoxClientID = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBoxClientInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblClientID
        '
        Me.lblClientID.AutoSize = True
        Me.lblClientID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientID.Location = New System.Drawing.Point(16, 36)
        Me.lblClientID.Name = "lblClientID"
        Me.lblClientID.Size = New System.Drawing.Size(47, 13)
        Me.lblClientID.TabIndex = 0
        Me.lblClientID.Text = "Client ID"
        '
        'lblClientName
        '
        Me.lblClientName.AutoSize = True
        Me.lblClientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientName.Location = New System.Drawing.Point(16, 72)
        Me.lblClientName.Name = "lblClientName"
        Me.lblClientName.Size = New System.Drawing.Size(35, 13)
        Me.lblClientName.TabIndex = 1
        Me.lblClientName.Text = "Name"
        '
        'lblSurnme
        '
        Me.lblSurnme.AutoSize = True
        Me.lblSurnme.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurnme.Location = New System.Drawing.Point(16, 108)
        Me.lblSurnme.Name = "lblSurnme"
        Me.lblSurnme.Size = New System.Drawing.Size(49, 13)
        Me.lblSurnme.TabIndex = 2
        Me.lblSurnme.Text = "Surname"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(16, 144)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(45, 13)
        Me.lblAddress.TabIndex = 3
        Me.lblAddress.Text = "Address"
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(16, 180)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(64, 13)
        Me.lblCode.TabIndex = 4
        Me.lblCode.Text = "Postal Code"
        '
        'lblHome
        '
        Me.lblHome.AutoSize = True
        Me.lblHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHome.Location = New System.Drawing.Point(16, 216)
        Me.lblHome.Name = "lblHome"
        Me.lblHome.Size = New System.Drawing.Size(69, 13)
        Me.lblHome.TabIndex = 5
        Me.lblHome.Text = "Home Phone"
        '
        'lblWork
        '
        Me.lblWork.AutoSize = True
        Me.lblWork.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWork.Location = New System.Drawing.Point(16, 252)
        Me.lblWork.Name = "lblWork"
        Me.lblWork.Size = New System.Drawing.Size(67, 13)
        Me.lblWork.TabIndex = 6
        Me.lblWork.Text = "Work Phone"
        '
        'lblCell
        '
        Me.lblCell.AutoSize = True
        Me.lblCell.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCell.Location = New System.Drawing.Point(16, 288)
        Me.lblCell.Name = "lblCell"
        Me.lblCell.Size = New System.Drawing.Size(58, 13)
        Me.lblCell.TabIndex = 7
        Me.lblCell.Text = "Cell Phone"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(16, 324)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 8
        Me.lblEmail.Text = "Email"
        '
        'lblReference
        '
        Me.lblReference.AutoSize = True
        Me.lblReference.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReference.Location = New System.Drawing.Point(16, 360)
        Me.lblReference.Name = "lblReference"
        Me.lblReference.Size = New System.Drawing.Size(57, 13)
        Me.lblReference.TabIndex = 9
        Me.lblReference.Text = "Reference"
        '
        'GroupBoxClientInfo
        '
        Me.GroupBoxClientInfo.Controls.Add(Me.TextBoxReference)
        Me.GroupBoxClientInfo.Controls.Add(Me.TextBoxEmail)
        Me.GroupBoxClientInfo.Controls.Add(Me.TextBoxCell)
        Me.GroupBoxClientInfo.Controls.Add(Me.TextBoxWork)
        Me.GroupBoxClientInfo.Controls.Add(Me.TextBoxHome)
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
        Me.GroupBoxClientInfo.TabIndex = 10
        Me.GroupBoxClientInfo.TabStop = False
        Me.GroupBoxClientInfo.Text = "Client Information"
        '
        'TextBoxReference
        '
        Me.TextBoxReference.Enabled = False
        Me.TextBoxReference.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxReference.Location = New System.Drawing.Point(145, 353)
        Me.TextBoxReference.Name = "TextBoxReference"
        Me.TextBoxReference.Size = New System.Drawing.Size(231, 20)
        Me.TextBoxReference.TabIndex = 19
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Enabled = False
        Me.TextBoxEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEmail.Location = New System.Drawing.Point(145, 317)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(231, 20)
        Me.TextBoxEmail.TabIndex = 18
        '
        'TextBoxCell
        '
        Me.TextBoxCell.Enabled = False
        Me.TextBoxCell.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCell.Location = New System.Drawing.Point(145, 281)
        Me.TextBoxCell.Name = "TextBoxCell"
        Me.TextBoxCell.Size = New System.Drawing.Size(231, 20)
        Me.TextBoxCell.TabIndex = 17
        '
        'TextBoxWork
        '
        Me.TextBoxWork.Enabled = False
        Me.TextBoxWork.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxWork.Location = New System.Drawing.Point(145, 245)
        Me.TextBoxWork.Name = "TextBoxWork"
        Me.TextBoxWork.Size = New System.Drawing.Size(231, 20)
        Me.TextBoxWork.TabIndex = 16
        '
        'TextBoxHome
        '
        Me.TextBoxHome.Enabled = False
        Me.TextBoxHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxHome.Location = New System.Drawing.Point(145, 209)
        Me.TextBoxHome.Name = "TextBoxHome"
        Me.TextBoxHome.Size = New System.Drawing.Size(231, 20)
        Me.TextBoxHome.TabIndex = 15
        '
        'TextBoxCode
        '
        Me.TextBoxCode.Enabled = False
        Me.TextBoxCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCode.Location = New System.Drawing.Point(145, 173)
        Me.TextBoxCode.Name = "TextBoxCode"
        Me.TextBoxCode.Size = New System.Drawing.Size(231, 20)
        Me.TextBoxCode.TabIndex = 14
        '
        'TextBoxAddress
        '
        Me.TextBoxAddress.Enabled = False
        Me.TextBoxAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAddress.Location = New System.Drawing.Point(145, 137)
        Me.TextBoxAddress.Name = "TextBoxAddress"
        Me.TextBoxAddress.Size = New System.Drawing.Size(231, 20)
        Me.TextBoxAddress.TabIndex = 13
        '
        'TextBoxSurname
        '
        Me.TextBoxSurname.Enabled = False
        Me.TextBoxSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSurname.Location = New System.Drawing.Point(145, 101)
        Me.TextBoxSurname.Name = "TextBoxSurname"
        Me.TextBoxSurname.Size = New System.Drawing.Size(231, 20)
        Me.TextBoxSurname.TabIndex = 12
        '
        'TextBoxName
        '
        Me.TextBoxName.Enabled = False
        Me.TextBoxName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxName.Location = New System.Drawing.Point(145, 65)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(231, 20)
        Me.TextBoxName.TabIndex = 11
        '
        'TextBoxClientID
        '
        Me.TextBoxClientID.Enabled = False
        Me.TextBoxClientID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxClientID.Location = New System.Drawing.Point(145, 29)
        Me.TextBoxClientID.Name = "TextBoxClientID"
        Me.TextBoxClientID.Size = New System.Drawing.Size(231, 20)
        Me.TextBoxClientID.TabIndex = 10
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(293, 433)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(86, 42)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(201, 433)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(86, 42)
        Me.btnEdit.TabIndex = 12
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(109, 433)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(86, 42)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        Me.btnSave.Visible = False
        '
        'AltHealthClientInfoDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 487)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.GroupBoxClientInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AltHealthClientInfoDisplay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AltHealth Client Information Display"
        Me.GroupBoxClientInfo.ResumeLayout(False)
        Me.GroupBoxClientInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblClientID As System.Windows.Forms.Label
    Friend WithEvents lblClientName As System.Windows.Forms.Label
    Friend WithEvents lblSurnme As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents lblHome As System.Windows.Forms.Label
    Friend WithEvents lblWork As System.Windows.Forms.Label
    Friend WithEvents lblCell As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblReference As System.Windows.Forms.Label
    Friend WithEvents GroupBoxClientInfo As System.Windows.Forms.GroupBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents TextBoxReference As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxEmail As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCell As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxWork As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxHome As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCode As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxAddress As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSurname As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxClientID As System.Windows.Forms.TextBox
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
