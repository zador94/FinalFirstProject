using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FinalFirstProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void Authorize(object sender, RoutedEventArgs e)
        {
            UserTable users = new UserTable();
            if (users.compareLoginPassword(loginBox.Text, passwordBox.Password))
            {
                SuccessfulLogin congratulations = new SuccessfulLogin();
                congratulations.Show();
            }
            else
            {
                ChoiceAction choiceAction = new ChoiceAction();
                choiceAction.Show();
            }
            this.Close();
        }

        private void UIElement_OnPreviewTextInput(object sender, KeyEventArgs keyEventArgs)
        { 
            UserTable users = new UserTable();
            
            if(users.compareLogin(loginBox.Text))
            {
                Image1.Source = new BitmapImage(new Uri(@"C:\Users\andru\RiderProjects\FinalFirstProject\FinalFirstProject\1.png"));
            }
            else
            {
                Image1.Source = new BitmapImage(new Uri(@"C:\Users\andru\RiderProjects\FinalFirstProject\FinalFirstProject\2.png"));
            }
        }

        private void UIElement_OnGotMouseCapture(object sender, MouseEventArgs e)
        {
            Point p = e.GetPosition(this);
            PointMouse.Text = $"X:{p.X.ToString()} Y: {p.Y.ToString()}";
        }
    }
}