using System.Windows;
using System.Windows.Controls;

namespace HellowWorld
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if (btn == bt1)
            {
                MessageBox.Show("You clicked   wrong botton!", "Oh, NO", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (btn == bt2)
            {
                MessageBox.Show("Yoho! You clicked the right button, Good job.", "Good job", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else if (btn == bt3)
            {
                MessageBox.Show("Hello, World", "Great job", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }
    }
}