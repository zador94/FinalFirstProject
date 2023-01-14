using System.Windows;

namespace FinalFirstProject;

public partial class WhatIsIt : Window
{
    public WhatIsIt()
    {
        InitializeComponent();
    }

    private void EndApp(object sender, RoutedEventArgs e)
    {
        this.Close();
    }
}