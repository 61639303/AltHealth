﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltHealthSupplierInfo
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
        Me.DataGridViewSupplierInfo = New System.Windows.Forms.DataGridView()
        Me.btnNewSupplier = New System.Windows.Forms.Button()
        Me.lblHelp = New System.Windows.Forms.Label()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        CType(Me.DataGridViewSupplierInfo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Location = New System.Drawing.Point(339, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(440, 54)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Supplier Information"
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
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Close"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'DataGridViewSupplierInfo
        '
        Me.DataGridViewSupplierInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewSupplierInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewSupplierInfo.Location = New System.Drawing.Point(217, 86)
        Me.DataGridViewSupplierInfo.Name = "DataGridViewSupplierInfo"
        Me.DataGridViewSupplierInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewSupplierInfo.Size = New System.Drawing.Size(656, 485)
        Me.DataGridViewSupplierInfo.TabIndex = 8
        '
        'btnNewSupplier
        '
        Me.btnNewSupplier.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnNewSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNewSupplier.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnNewSupplier.Location = New System.Drawing.Point(23, 206)
        Me.btnNewSupplier.Name = "btnNewSupplier"
        Me.btnNewSupplier.Size = New System.Drawing.Size(142, 55)
        Me.btnNewSupplier.TabIndex = 9
        Me.btnNewSupplier.Text = "Add New Supplier"
        Me.btnNewSupplier.UseVisualStyleBackColor = False
        '
        'lblHelp
        '
        Me.lblHelp.AutoSize = True
        Me.lblHelp.ForeColor = System.Drawing.Color.Green
        Me.lblHelp.Location = New System.Drawing.Point(214, 574)
        Me.lblHelp.Name = "lblHelp"
        Me.lblHelp.Size = New System.Drawing.Size(238, 13)
        Me.lblHelp.TabIndex = 10
        Me.lblHelp.Text = "Double click a record to view full details or to edit"
        '
        'btnExport
        '
        Me.btnExport.BackgroundImage = Global.AltHealth.My.Resources.Resources.MSEXCELL2
        Me.btnExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExport.Location = New System.Drawing.Point(804, 586)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(58, 41)
        Me.btnExport.TabIndex = 23
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'FolderBrowserDialog1
        '
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(217, 600)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(562, 27)
        Me.ProgressBar1.TabIndex = 24
        Me.ProgressBar1.Visible = False
        '
        'AltHealthSupplierInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AltHealth.My.Resources.Resources._61639303_Logo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(885, 647)
        Me.ControlBox = False
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.lblHelp)
        Me.Controls.Add(Me.btnNewSupplier)
        Me.Controls.Add(Me.DataGridViewSupplierInfo)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "AltHealthSupplierInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AltHealth Supplier Info"
        CType(Me.DataGridViewSupplierInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents DataGridViewSupplierInfo As System.Windows.Forms.DataGridView
    Friend WithEvents btnNewSupplier As System.Windows.Forms.Button
    Friend WithEvents lblHelp As System.Windows.Forms.Label
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
End Class
