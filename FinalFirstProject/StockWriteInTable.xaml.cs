using System.Windows;

namespace FinalFirstProject;

public partial class StockWriteInTable : Window
{
    public StockWriteInTable()
    {
        InitializeComponent();
    }

    private void WriteTableWindow(object sender, RoutedEventArgs e)
    {
        this.Close();
    }
}