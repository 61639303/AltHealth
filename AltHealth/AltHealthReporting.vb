Imports System.Data.SqlClient

Public Class AltHealthReporting

    'Variable to connect to database
    Dim connection As New SqlConnection("Server = GERRITRENTIA-PC\SQLEXPRESS; Database =  AltHealth; Integrated Security=True")

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        'If User clicks yes, the Reporting screen is closed
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to close the Reporting screen?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnUnpaid_Click(sender As System.Object, e As System.EventArgs) Handles btnUnpaid.Click
        'Hides the Chart
        Chart1.Hide()
        'SQL Query to look for all unpaid Invoices
        Dim adapter As New SqlDataAdapter("Select a.Client_id as 'CLIENT ID', b.C_name + b.C_surname as 'CLIENT NAME', a.inv_Num as 'INVOICE NUMBER', a.Inv_Date as 'INVOICE DATE' from tblInv_info a, tblClientInfo b where Inv_Paid = 'N' and Inv_Date < '2020-01-01' and a.Client_id = b.Client_id order by  a.Client_id ASC ", connection)
        'Fills the temporary table and updates the Datagridview
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridViewReport.DataSource = table
    End Sub

    Private Sub btnBirthdays_Click(sender As System.Object, e As System.EventArgs) Handles btnBirthdays.Click
        'Hides the Chart
        Chart1.Hide()
        Dim adapter As New SqlDataAdapter("Select Client_id as 'CLIENT ID', C_name + C_surname as 'CLIENT NAME' from tblClientInfo where '2020-' + SUBSTRING  (Client_id, 3, 2) + '-' + SUBSTRING  (Client_id, 5, 2) = CONVERT(DATE,getdate())", connection)
        'Fills the temporary table and updates the Datagridview
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridViewReport.DataSource = table
    End Sub

    Private Sub btnMinLvl_Click(sender As System.Object, e As System.EventArgs) Handles btnMinLvl.Click
        'Hides the Chart
        Chart1.Hide()
        Dim adapter As New SqlDataAdapter("Select a.Supplement_id as 'SUPPLEMENT ID', b.Supplier_ID + ' ' + b.Contact_Person + ' ' + b.Supplier_Tel as 'SUPPLIER INFORMATION',a.Min_levels as 'MINIMUM LEVEL', a.Current_stock_levels as 'CURRENT STOCK LEVEL' from tblSupplements a , tblSupplier_Info b where Current_stock_levels < Min_levels and a.Supplier_ID = b.Supplier_ID order by b.Supplier_ID", connection)
        'Fills the temporary table and updates the Datagridview
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridViewReport.DataSource = table
    End Sub

    Private Sub btnTop10_Click(sender As System.Object, e As System.EventArgs) Handles btnTop10.Click
        'Shows the Chart
        Chart1.Show()
        Dim adapter As New SqlDataAdapter("select top 10 a.client_id ,  b.C_name +''+ b.C_surname as 'CLIENT', count(a.Client_id) as 'FREQUENCY' from tblInv_info a, tblClientInfo b where Inv_Date between '2018-01-01' and '2019-12-31' and a.Client_id = b.Client_id group by a.client_id, b.c_name, b.C_surname order by Frequency desc", connection)
        'Fills the temporary table and updates the Datagridview
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridViewReport.DataSource = table

        'Fills the chart with the query data
        Chart1.DataSource = table
        With Chart1.Series(0)
            .Name = "Frequency"
            .Font = New Font("Arial", 8, FontStyle.Italic)
            .Color = Color.Blue
            .BackSecondaryColor = Color.Magenta
            .IsValueShownAsLabel = True
            .LabelBackColor = Color.LightYellow
            .LabelForeColor = Color.Blue
            .Points.DataBind(table.DefaultView, "CLIENT", "FREQUENCY", Nothing)

        End With
        With Chart1.ChartAreas(0)
            .AxisX.Interval = 1
            .AxisX.LabelStyle.Angle = 0
            .AxisX.Title = "Client"
            .AxisY.Title = "Frequency"
        End With
        With Chart1.Series(0)
            .ChartType = DataVisualization.Charting.SeriesChartType.Bar
        End With
    End Sub

    Private Sub btnPurchases_Click(sender As System.Object, e As System.EventArgs) Handles btnPurchases.Click
        'Shows the Chart
        Chart1.Show()
        Dim adapter As New SqlDataAdapter("select count (Inv_Num) as 'NUM OF PURCHASES' ,  DATENAME(MONTH,Inv_Date) as 'MONTH' from tblInv_info where DATENAME(YEAR,Inv_Date) > 2011 group by DATENAME(MONTH,Inv_Date) , MONTH(Inv_Date) order by MONTH(Inv_Date)", connection)
        'Fills the temporary table and updates the Datagridview
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridViewReport.DataSource = table
        'Fills the chart with the query data
        Chart1.DataSource = table
        With Chart1.Series(0)
            .Name = "Number of Purchases"
            .Font = New Font("Arial", 8, FontStyle.Italic)
            .Color = Color.Blue
            .BackSecondaryColor = Color.Magenta
            .IsValueShownAsLabel = True
            .LabelBackColor = Color.LightYellow
            .LabelForeColor = Color.Blue
            .Points.DataBind(table.DefaultView, "MONTH", "NUM OF PURCHASES", Nothing)
        End With
        With Chart1.ChartAreas(0)
            .AxisX.Interval = 1
            .AxisX.LabelStyle.Angle = -90
            .AxisX.Title = "Month"
            .AxisY.Title = "Purchases"
        End With
        With Chart1.Series(0)
            .ChartType = DataVisualization.Charting.SeriesChartType.Line
        End With
    End Sub

    Private Sub btnClientContact_Click(sender As System.Object, e As System.EventArgs) Handles btnClientContact.Click
        'Hides the Chart
        Chart1.Hide()
        Dim adapter As New SqlDataAdapter("select Client_id as 'CLIENT' , C_Tel_H as 'HOME', C_Tel_W as 'WORK' , C_Tel_C as 'CELL', C_Email as 'EMAIL' from tblClientInfo where NULLIF(C_TEL_C,'') IS NULL AND NULLIF(C_EMAIL,'') IS NULL", connection)
        'Fills the temporary table and updates the Datagridview
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridViewReport.DataSource = table
    End Sub

    Private Sub AltHealthReporting_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Hides the Chart
        Chart1.Hide()
    End Sub
End Class