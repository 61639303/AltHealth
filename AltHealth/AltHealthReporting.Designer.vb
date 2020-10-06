<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltHealthReporting
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AltHealthReporting))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnUnpaid = New System.Windows.Forms.Button()
        Me.btnBirthdays = New System.Windows.Forms.Button()
        Me.btnMinLvl = New System.Windows.Forms.Button()
        Me.btnTop10 = New System.Windows.Forms.Button()
        Me.btnPurchases = New System.Windows.Forms.Button()
        Me.btnClientContact = New System.Windows.Forms.Button()
        Me.DataGridViewReport = New System.Windows.Forms.DataGridView()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnTotalSold = New System.Windows.Forms.Button()
        Me.btnReferences = New System.Windows.Forms.Button()
        CType(Me.DataGridViewReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Location = New System.Drawing.Point(439, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 54)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Reporting"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnExit.Location = New System.Drawing.Point(25, 625)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(142, 55)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Close"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnUnpaid
        '
        Me.btnUnpaid.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnUnpaid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnUnpaid.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnUnpaid.Location = New System.Drawing.Point(223, 93)
        Me.btnUnpaid.Name = "btnUnpaid"
        Me.btnUnpaid.Size = New System.Drawing.Size(154, 50)
        Me.btnUnpaid.TabIndex = 7
        Me.btnUnpaid.Text = "Unpaid Invoices"
        Me.btnUnpaid.UseVisualStyleBackColor = False
        '
        'btnBirthdays
        '
        Me.btnBirthdays.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnBirthdays.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBirthdays.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnBirthdays.Location = New System.Drawing.Point(383, 93)
        Me.btnBirthdays.Name = "btnBirthdays"
        Me.btnBirthdays.Size = New System.Drawing.Size(154, 50)
        Me.btnBirthdays.TabIndex = 8
        Me.btnBirthdays.Text = "Birthdays"
        Me.btnBirthdays.UseVisualStyleBackColor = False
        '
        'btnMinLvl
        '
        Me.btnMinLvl.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnMinLvl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMinLvl.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnMinLvl.Location = New System.Drawing.Point(543, 93)
        Me.btnMinLvl.Name = "btnMinLvl"
        Me.btnMinLvl.Size = New System.Drawing.Size(154, 50)
        Me.btnMinLvl.TabIndex = 9
        Me.btnMinLvl.Text = "Minimum Stock Levels"
        Me.btnMinLvl.UseVisualStyleBackColor = False
        '
        'btnTop10
        '
        Me.btnTop10.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnTop10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnTop10.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnTop10.Location = New System.Drawing.Point(703, 93)
        Me.btnTop10.Name = "btnTop10"
        Me.btnTop10.Size = New System.Drawing.Size(154, 50)
        Me.btnTop10.TabIndex = 10
        Me.btnTop10.Text = "Top 10 Clients 2018 and 2019"
        Me.btnTop10.UseVisualStyleBackColor = False
        '
        'btnPurchases
        '
        Me.btnPurchases.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnPurchases.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPurchases.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnPurchases.Location = New System.Drawing.Point(223, 149)
        Me.btnPurchases.Name = "btnPurchases"
        Me.btnPurchases.Size = New System.Drawing.Size(154, 50)
        Me.btnPurchases.TabIndex = 11
        Me.btnPurchases.Text = "Purchases per Month"
        Me.btnPurchases.UseVisualStyleBackColor = False
        '
        'btnClientContact
        '
        Me.btnClientContact.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnClientContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnClientContact.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnClientContact.Location = New System.Drawing.Point(383, 149)
        Me.btnClientContact.Name = "btnClientContact"
        Me.btnClientContact.Size = New System.Drawing.Size(154, 50)
        Me.btnClientContact.TabIndex = 12
        Me.btnClientContact.Text = "Client Missing Contact Information"
        Me.btnClientContact.UseVisualStyleBackColor = False
        '
        'DataGridViewReport
        '
        Me.DataGridViewReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewReport.Location = New System.Drawing.Point(217, 209)
        Me.DataGridViewReport.Name = "DataGridViewReport"
        Me.DataGridViewReport.Size = New System.Drawing.Size(646, 261)
        Me.DataGridViewReport.TabIndex = 13
        '
        'Chart1
        '
        ChartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal
        ChartArea1.AxisY2.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(217, 476)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(646, 204)
        Me.Chart1.TabIndex = 14
        Me.Chart1.Text = "Chart1"
        '
        'btnTotalSold
        '
        Me.btnTotalSold.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnTotalSold.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnTotalSold.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnTotalSold.Location = New System.Drawing.Point(543, 149)
        Me.btnTotalSold.Name = "btnTotalSold"
        Me.btnTotalSold.Size = New System.Drawing.Size(154, 50)
        Me.btnTotalSold.TabIndex = 15
        Me.btnTotalSold.Text = "Top Products"
        Me.btnTotalSold.UseVisualStyleBackColor = False
        '
        'btnReferences
        '
        Me.btnReferences.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnReferences.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnReferences.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnReferences.Location = New System.Drawing.Point(703, 149)
        Me.btnReferences.Name = "btnReferences"
        Me.btnReferences.Size = New System.Drawing.Size(154, 50)
        Me.btnReferences.TabIndex = 16
        Me.btnReferences.Text = "Top References"
        Me.btnReferences.UseVisualStyleBackColor = False
        '
        'AltHealthReporting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(876, 691)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnReferences)
        Me.Controls.Add(Me.btnTotalSold)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.DataGridViewReport)
        Me.Controls.Add(Me.btnClientContact)
        Me.Controls.Add(Me.btnPurchases)
        Me.Controls.Add(Me.btnTop10)
        Me.Controls.Add(Me.btnMinLvl)
        Me.Controls.Add(Me.btnBirthdays)
        Me.Controls.Add(Me.btnUnpaid)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AltHealthReporting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AltHealth Reporting"
        CType(Me.DataGridViewReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnUnpaid As System.Windows.Forms.Button
    Friend WithEvents btnBirthdays As System.Windows.Forms.Button
    Friend WithEvents btnMinLvl As System.Windows.Forms.Button
    Friend WithEvents btnTop10 As System.Windows.Forms.Button
    Friend WithEvents btnPurchases As System.Windows.Forms.Button
    Friend WithEvents btnClientContact As System.Windows.Forms.Button
    Friend WithEvents DataGridViewReport As System.Windows.Forms.DataGridView
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents btnTotalSold As System.Windows.Forms.Button
    Friend WithEvents btnReferences As System.Windows.Forms.Button
End Class
