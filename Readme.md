<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128578393/22.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2048)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WPF Pivot Grid -  Bind a PivotGrid to an OLAP Cube (.NET 6.0)
This example demonstrates how to bind Pivot Grid to an MS OLAP cube.

<!-- default file list -->
## Files to Look at
* [MainWindow.xaml](./CS/HowToBindOLAP/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/HowToBindOLAP/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/HowToBindOLAP/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/HowToBindOLAP/MainWindow.xaml.vb))
<!-- default file list end -->

## Prerequisites

- [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/) 
- [Microsoft.AnalysisServices.NetCore.retail.amd64](https://www.nuget.org/packages/Microsoft.AnalysisServices.NetCore.retail.amd64)
 
## Example Overview

1. Create a data connection. For this, specify the [OlapConnectionString](https://docs.devexpress.com/WPF/DevExpress.Xpf.PivotGrid.PivotGridControl.OlapConnectionString) property.
2. Create Pivot Grid fields and bind them to data. For this, use [DataSourceColumnBinding](https://docs.devexpress.com/WPF/DevExpress.Xpf.PivotGrid.DataSourceColumnBinding).
3. Add the created fields to the [PivotGridControl.Fields](https://docs.devexpress.com/WPF/DevExpress.Xpf.PivotGrid.PivotGridControl.Fields) collection. 

## Documentation

- [OLAP Mode](https://docs.devexpress.com/CoreLibraries/403809/devexpress-pivot-grid-core-library/pivot-grid-modes/olap-mode?v=22.1)

## More Examples 

- [WPF Pivot Grid - Getting Started - Bind a Pivot Grid to an OLAP Cube](https://github.com/DevExpress-Examples/wpf-pivot-grid-getting-started-bind-a-pivot-grid-to-an-olap-cube-runtime-sample-t540936)
- [WPF Pivot Grid - Bind the Pivot Grid to an MS Access Database at Runtime](https://github.com/DevExpress-Examples/winforms-pivot-grid-connect-to-an-access-database-in-code)




