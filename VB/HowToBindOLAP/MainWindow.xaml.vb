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
            Dim fieldMeasuresInternetSalesAmount As PivotGridField = New PivotGridField("[Measures].[Internet Sales Amount]", FieldArea.DataArea)
            fieldMeasuresInternetSalesAmount.Caption = "Internet Sales Amount"
            Dim fieldCustomerCountryCountry As PivotGridField = New PivotGridField("[Customer].[Country].[Country]", FieldArea.RowArea)
            fieldCustomerCountryCountry.Caption = "Country"
            Dim fieldDateFiscalYearFiscalYear As PivotGridField = New PivotGridField("[Date].[Fiscal Year].[Fiscal Year]", FieldArea.ColumnArea)
            fieldDateFiscalYearFiscalYear.Caption = "Fiscal Year"
            ' Add fields to the PivotGridControl
            Me.pivotGridControl1.Fields.AddRange(fieldMeasuresInternetSalesAmount, fieldCustomerCountryCountry, fieldDateFiscalYearFiscalYear)
            Me.pivotGridControl1.EndUpdate()
        End Sub
    End Class
End Namespace
