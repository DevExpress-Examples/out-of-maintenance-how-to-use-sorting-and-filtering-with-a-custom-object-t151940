Imports System.Windows
Imports System.Windows.Controls

Namespace FilteringWithComboBoxEditor

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.grid1.ItemsSource = Data.DataList
        End Sub
    End Class
End Namespace
