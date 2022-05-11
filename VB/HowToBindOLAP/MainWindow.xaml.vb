Imports System.Windows
Imports DevExpress.Xpf.PivotGrid

Namespace HowToBindOLAP
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub
		Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			pivotGridControl1.OlapConnectionString = "Provider=msolap;" & "Data Source=http://demos.devexpress.com/Services/OLAP/msmdpump.dll;" &
				"Initial Catalog=Adventure Works DW Standard Edition;" & "Cube Name=Adventure Works;"
			pivotGridControl1.BeginUpdate()

			' Create fields.
			Dim fieldMeasuresInternetSalesAmount As New PivotGridField()
			fieldMeasuresInternetSalesAmount.Caption = "Internet Sales Amount"
			fieldMeasuresInternetSalesAmount.Area = FieldArea.DataArea
			fieldMeasuresInternetSalesAmount.DataBinding = New DataSourceColumnBinding("[Measures].[Internet Sales Amount]")

			Dim fieldCustomerCountryCountry As New PivotGridField()
			fieldCustomerCountryCountry.Caption = "Country"
			fieldCustomerCountryCountry.Area = FieldArea.RowArea
			fieldCustomerCountryCountry.DataBinding = New DataSourceColumnBinding("[Customer].[Country].[Country]")

			Dim fieldDateFiscalYearFiscalYear As New PivotGridField()
			fieldDateFiscalYearFiscalYear.Caption = "Fiscal Year"
			fieldDateFiscalYearFiscalYear.Area = FieldArea.ColumnArea
			fieldDateFiscalYearFiscalYear.DataBinding = New DataSourceColumnBinding("[Date].[Fiscal Year].[Fiscal Year]")

			' Add fields to the PivotGridControl
			pivotGridControl1.Fields.AddRange(fieldMeasuresInternetSalesAmount, fieldCustomerCountryCountry,
				fieldDateFiscalYearFiscalYear)

			pivotGridControl1.EndUpdate()
		End Sub
	End Class
End Namespace
