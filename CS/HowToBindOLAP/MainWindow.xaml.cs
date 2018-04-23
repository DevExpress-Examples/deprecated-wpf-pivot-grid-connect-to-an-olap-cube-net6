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
                new PivotGridField("[Measures].[Internet Sales Amount]", FieldArea.DataArea);
            fieldMeasuresInternetSalesAmount.Caption = "Internet Sales Amount";
            
            PivotGridField fieldCustomerCountryCountry = 
                new PivotGridField("[Customer].[Country].[Country]", FieldArea.RowArea);
            fieldCustomerCountryCountry.Caption = "Country";
            
            PivotGridField fieldDateFiscalYearFiscalYear = 
                new PivotGridField("[Date].[Fiscal Year].[Fiscal Year]", FieldArea.ColumnArea);
            fieldDateFiscalYearFiscalYear.Caption = "Fiscal Year";
            
            // Add fields to the PivotGridControl
            pivotGridControl1.Fields.AddRange(fieldMeasuresInternetSalesAmount, 
                fieldCustomerCountryCountry, fieldDateFiscalYearFiscalYear);

            pivotGridControl1.EndUpdate();
        }
    }
}
