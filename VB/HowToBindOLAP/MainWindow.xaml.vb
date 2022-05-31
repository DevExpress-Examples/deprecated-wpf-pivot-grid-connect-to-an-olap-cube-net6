Imports System.Windows
Imports DevExpress.Xpf.PivotGrid

Namespace HowToBindOLAP

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Me.pivotGridControl1.OlapConnectionString = "Provider=msolap;" & "Data Source=http://demos.devexpress.com/Services/OLAP/msmdpump.dll;" & "Initial Catalog=Adventure Works DW Standard Edition;" & "Cube Name=Adventure Works;"
            Me.pivotGridControl1.BeginUpdate()
            ' Create fields.
            Dim fieldMeasuresInternetSalesAmount As PivotGridField = New PivotGridField()
            fieldMeasuresInternetSalesAmount.Caption = "Internet Sales Amount"
            fieldMeasuresInternetSalesAmount.Area = FieldArea.DataArea
            fieldMeasuresInternetSalesAmount.DataBinding = New DataSourceColumnBinding("[Measures].[Internet Sales Amount]")
            Dim fieldCustomerCountryCountry As PivotGridField = New PivotGridField()
            fieldCustomerCountryCountry.Caption = "Country"
            fieldCustomerCountryCountry.Area = FieldArea.RowArea
            fieldCustomerCountryCountry.DataBinding = New DataSourceColumnBinding("[Customer].[Country].[Country]")
            Dim fieldDateFiscalYearFiscalYear As PivotGridField = New PivotGridField()
            fieldDateFiscalYearFiscalYear.Caption = "Fiscal Year"
            fieldDateFiscalYearFiscalYear.Area = FieldArea.ColumnArea
            fieldDateFiscalYearFiscalYear.DataBinding = New DataSourceColumnBinding("[Date].[Fiscal Year].[Fiscal Year]")
            Dim fieldSales As PivotGridField = New PivotGridField()
            fieldSales.Caption = "Cleared Amount"
            fieldSales.Area = FieldArea.DataArea
            fieldSales.DataBinding = New OlapExpressionBinding("[Measures].[Internet Sales Amount] * 0.87")
            fieldSales.CellFormat = "c"
            ' Add fields to the PivotGridControl
            Me.pivotGridControl1.Fields.AddRange(fieldMeasuresInternetSalesAmount, fieldCustomerCountryCountry, fieldDateFiscalYearFiscalYear, fieldSales)
            Me.pivotGridControl1.EndUpdate()
        End Sub
    End Class
End Namespace
