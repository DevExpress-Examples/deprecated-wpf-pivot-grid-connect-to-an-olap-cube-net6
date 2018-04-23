Imports System.Windows
Imports DevExpress.Xpf.PivotGrid

Namespace HowToBindOLAP
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            pivotGridControl1.OlapConnectionString = "Provider=msolap;" &
                "Data Source=http://demos.devexpress.com/Services/OLAP/msmdpump.dll;" &
                "Initial Catalog=Adventure Works DW Standard Edition;" &
                "Cube Name=Adventure Works;"
            pivotGridControl1.BeginUpdate()

            ' Create fields.
            Dim fieldMeasuresInternetSalesAmount As New  _
                PivotGridField("[Measures].[Internet Sales Amount]", FieldArea.DataArea)
            fieldMeasuresInternetSalesAmount.Caption = "Internet Sales Amount"

            Dim fieldCustomerCountryCountry As New  _
                PivotGridField("[Customer].[Country].[Country]", FieldArea.RowArea)
            fieldCustomerCountryCountry.Caption = "Country"

            Dim fieldDateFiscalYearFiscalYear As New  _
                PivotGridField("[Date].[Fiscal Year].[Fiscal Year]", FieldArea.ColumnArea)
            fieldDateFiscalYearFiscalYear.Caption = "Fiscal Year"

            ' Add fields to the PivotGridControl
            pivotGridControl1.Fields.AddRange(fieldMeasuresInternetSalesAmount, _
                                        fieldCustomerCountryCountry, fieldDateFiscalYearFiscalYear)
            pivotGridControl1.EndUpdate()
        End Sub
    End Class
End Namespace
