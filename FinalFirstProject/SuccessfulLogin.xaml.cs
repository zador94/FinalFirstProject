using System.Windows;

namespace FinalFirstProject;

public partial class SuccessfulLogin : Window
{
    public SuccessfulLogin()
    {
        InitializeComponent();
    }
    private void CloseWindow(object sender, RoutedEventArgs e)
    {
        MainWindowStock mainWindowStock = new MainWindowStock();
        mainWindowStock.Show();
        this.Close();
    }
}