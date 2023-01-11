using System.Windows;

namespace FinalFirstProject;

public partial class MainWindowStock : Window
{
    public MainWindowStock()
    {
        InitializeComponent();
    }
    public void AddToBase(object sender, RoutedEventArgs e)
    {
            
        AddProductStock stock = new AddProductStock();
        foreach (var test in ProductsGrid.ItemsSource)
        {
            stock.addProduct((test as Product).ProductName, (test as Product).Price, (test as Product).Quantity);
        }
    }

    private void WriteToBase(object sender, RoutedEventArgs e)
    {
        AddProductStock stock = new AddProductStock();
        ProductsGrid.ItemsSource = stock.readFromBase();
    }
}