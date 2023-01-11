using System.Windows;

namespace FinalFirstProject;

public partial class ChoiceAction : Window
{
    public ChoiceAction()
    {
        InitializeComponent();
    }
    private void AgainAutorization(object sender, RoutedEventArgs e)
    {
        MainWindow mainWindow = new MainWindow();
        mainWindow.Show();
        this.Close();
    }

    private void RegistrationUsers(object sender, RoutedEventArgs e)
    {
        Registration registration = new Registration();
        registration.Show();
        this.Close();
    }
}