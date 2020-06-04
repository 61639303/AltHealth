<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltHealthClientInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AltHealthClientInfo))
        Me.btnClientInfo = New System.Windows.Forms.Button()
        Me.btnSupplierInfo = New System.Windows.Forms.Button()
        Me.btnSupplementInfo = New System.Windows.Forms.Button()
        Me.btnReporting = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnClientInfo
        '
        Me.btnClientInfo.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnClientInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnClientInfo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnClientInfo.Location = New System.Drawing.Point(12, 214)
        Me.btnClientInfo.Name = "btnClientInfo"
        Me.btnClientInfo.Size = New System.Drawing.Size(177, 78)
        Me.btnClientInfo.TabIndex = 0
        Me.btnClientInfo.Text = "Client Information"
        Me.btnClientInfo.UseVisualStyleBackColor = False
        '
        'btnSupplierInfo
        '
        Me.btnSupplierInfo.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnSupplierInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSupplierInfo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSupplierInfo.Location = New System.Drawing.Point(12, 298)
        Me.btnSupplierInfo.Name = "btnSupplierInfo"
        Me.btnSupplierInfo.Size = New System.Drawing.Size(177, 78)
        Me.btnSupplierInfo.TabIndex = 1
        Me.btnSupplierInfo.Text = "Supplier Information"
        Me.btnSupplierInfo.UseVisualStyleBackColor = False
        '
        'btnSupplementInfo
        '
        Me.btnSupplementInfo.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnSupplementInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSupplementInfo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSupplementInfo.Location = New System.Drawing.Point(12, 381)
        Me.btnSupplementInfo.Name = "btnSupplementInfo"
        Me.btnSupplementInfo.Size = New System.Drawing.Size(177, 78)
        Me.btnSupplementInfo.TabIndex = 2
        Me.btnSupplementInfo.Text = "Supplement Information"
        Me.btnSupplementInfo.UseVisualStyleBackColor = False
        '
        'btnReporting
        '
        Me.btnReporting.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnReporting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnReporting.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnReporting.Location = New System.Drawing.Point(12, 464)
        Me.btnReporting.Name = "btnReporting"
        Me.btnReporting.Size = New System.Drawing.Size(177, 78)
        Me.btnReporting.TabIndex = 3
        Me.btnReporting.Text = "Reporting"
        Me.btnReporting.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Location = New System.Drawing.Point(270, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(388, 54)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Client Information"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'AltHealthClientInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(885, 551)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnReporting)
        Me.Controls.Add(Me.btnSupplementInfo)
        Me.Controls.Add(Me.btnSupplierInfo)
        Me.Controls.Add(Me.btnClientInfo)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "AltHealthClientInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AltHealth Client Info"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClientInfo As System.Windows.Forms.Button
    Friend WithEvents btnSupplierInfo As System.Windows.Forms.Button
    Friend WithEvents btnSupplementInfo As System.Windows.Forms.Button
    Friend WithEvents btnReporting As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
