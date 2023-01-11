using System.Windows;

namespace FinalFirstProject;

public partial class ErrorLogin : Window
{
    public ErrorLogin()
    {
        InitializeComponent();
    }
    private void EndApp(object sender, RoutedEventArgs e)
    {
        this.Close();
    }
    
    
    private void ReturnRegistration(object sender, RoutedEventArgs e)
    {
        Registration registration = new Registration();
        registration.Show();
        this.Close();
    }
}