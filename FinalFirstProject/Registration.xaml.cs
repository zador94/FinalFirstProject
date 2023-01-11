using System.Windows;

namespace FinalFirstProject;

public partial class Registration : Window
{
    public Registration()
    {
        InitializeComponent();
    }

    private void RegistrationNewUsers(object sender, RoutedEventArgs e)
    {

        UserTable userTable = new UserTable();
        if (loginBox.Text == "" || passwordBox.Password == "")
        {
            MessageBox.Show("Заполните все поля");
        }
        else if (!userTable.compareLoginPassword(loginBox.Text, passwordBox.Password))
        {
            userTable.registrationUsers(loginBox.Text, passwordBox.Password);
            SuccessRegistration succes = new SuccessRegistration();
            succes.Show();
            this.Close();
        }
        else
        {
            ErrorLogin error = new ErrorLogin();
            error.Show();
            this.Close();
        }
    }
}