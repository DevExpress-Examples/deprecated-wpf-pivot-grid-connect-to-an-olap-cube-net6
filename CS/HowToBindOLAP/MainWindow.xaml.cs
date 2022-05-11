using System.Windows;
using DevExpress.Xpf.PivotGrid;

namespace HowToBindOLAP {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e) {
            pivotGridControl1.OlapConnectionString = "Provider=msolap;" +
                "Data Source=http://demos.devexpress.com/Services/OLAP/msmdpump.dll;" + 
                "Initial Catalog=Adventure Works DW Standard Edition;" +
                "Cube Name=Adventure Works;";
            pivotGridControl1.BeginUpdate();

            // Create fields.
            PivotGridField fieldMeasuresInternetSalesAmount = 
                new PivotGridField();
            fieldMeasuresInternetSalesAmount.Caption = "Internet Sales Amount";
            fieldMeasuresInternetSalesAmount.Area = FieldArea.DataArea;
            fieldMeasuresInternetSalesAmount.DataBinding = 
                new DataSourceColumnBinding("[Measures].[Internet Sales Amount]");

            PivotGridField fieldCustomerCountryCountry = 
                new PivotGridField();
            fieldCustomerCountryCountry.Caption = "Country";
            fieldCustomerCountryCountry.Area = FieldArea.RowArea;
            fieldCustomerCountryCountry.DataBinding = 
                new DataSourceColumnBinding("[Customer].[Country].[Country]");
            
            PivotGridField fieldDateFiscalYearFiscalYear = 
                new PivotGridField();
            fieldDateFiscalYearFiscalYear.Caption = "Fiscal Year";
            fieldDateFiscalYearFiscalYear.Area = FieldArea.ColumnArea;
            fieldDateFiscalYearFiscalYear.DataBinding = 
                new DataSourceColumnBinding("[Date].[Fiscal Year].[Fiscal Year]");

            // Add fields to the PivotGridControl
            pivotGridControl1.Fields.AddRange(fieldMeasuresInternetSalesAmount, 
                fieldCustomerCountryCountry, fieldDateFiscalYearFiscalYear);

            pivotGridControl1.EndUpdate();
        }
    }
}
