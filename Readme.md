<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128653735/14.1.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T151940)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Converter.cs](./CS/FilteringWithComboBoxEditor/Converter.cs) (VB: [Converter.vb](./VB/FilteringWithComboBoxEditor/Converter.vb))
* [Data.cs](./CS/FilteringWithComboBoxEditor/Data.cs) (VB: [Data.vb](./VB/FilteringWithComboBoxEditor/Data.vb))
* [MainWindow.xaml](./CS/FilteringWithComboBoxEditor/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/FilteringWithComboBoxEditor/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/FilteringWithComboBoxEditor/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/FilteringWithComboBoxEditor/MainWindow.xaml.vb))
<!-- default file list end -->
# How to use sorting and filtering with a custom object


<p>When a column contains custom objects as values, these custom objects cannot be compared directly. Data can be sorted and filtered by displayed text. It can be done in the following way:</p>
<p>1) Change the column CellTemplate property that allows an end-user to change object values (e.g., select them from the ComboBox);</p>
<p>2) Set EditSettings for this column and define DisplayTextConverter;</p>
<p>3) Set the SortMode and ColumnFilterMode properties to DisplayText, and set the AllowSorting property to true.</p>
<p>The end-user will always see the data set from CellTemplate, but sorting and filtering will be applied by using text converted by DisplayTextConverter.</p>

<br/>


