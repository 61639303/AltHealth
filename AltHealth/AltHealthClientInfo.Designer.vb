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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.DataGridViewClientInfo = New System.Windows.Forms.DataGridView()
        Me.btnNewClient = New System.Windows.Forms.Button()
        Me.lblHelp = New System.Windows.Forms.Label()
        CType(Me.DataGridViewClientInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Location = New System.Drawing.Point(357, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(388, 54)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Client Information"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnExit.Location = New System.Drawing.Point(23, 572)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(142, 55)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Close"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'DataGridViewClientInfo
        '
        Me.DataGridViewClientInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewClientInfo.Location = New System.Drawing.Point(217, 86)
        Me.DataGridViewClientInfo.Name = "DataGridViewClientInfo"
        Me.DataGridViewClientInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewClientInfo.Size = New System.Drawing.Size(656, 536)
        Me.DataGridViewClientInfo.TabIndex = 6
        '
        'btnNewClient
        '
        Me.btnNewClient.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnNewClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNewClient.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnNewClient.Location = New System.Drawing.Point(23, 206)
        Me.btnNewClient.Name = "btnNewClient"
        Me.btnNewClient.Size = New System.Drawing.Size(142, 55)
        Me.btnNewClient.TabIndex = 7
        Me.btnNewClient.Text = "New Client"
        Me.btnNewClient.UseVisualStyleBackColor = False
        '
        'lblHelp
        '
        Me.lblHelp.AutoSize = True
        Me.lblHelp.ForeColor = System.Drawing.Color.Green
        Me.lblHelp.Location = New System.Drawing.Point(221, 628)
        Me.lblHelp.Name = "lblHelp"
        Me.lblHelp.Size = New System.Drawing.Size(194, 13)
        Me.lblHelp.TabIndex = 8
        Me.lblHelp.Text = "Double click a record to view full details"
        '
        'AltHealthClientInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AltHealth.My.Resources.Resources._61639303_Logo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(885, 647)
        Me.Controls.Add(Me.lblHelp)
        Me.Controls.Add(Me.btnNewClient)
        Me.Controls.Add(Me.DataGridViewClientInfo)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AltHealthClientInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AltHealth Client Info"
        CType(Me.DataGridViewClientInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents DataGridViewClientInfo As System.Windows.Forms.DataGridView
    Friend WithEvents btnNewClient As System.Windows.Forms.Button
    Friend WithEvents lblHelp As System.Windows.Forms.Label
End Class
