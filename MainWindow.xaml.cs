using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Assignment3
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
        private void ToggleSubmit()
        {
            uxSubmit.IsEnabled = !(uxName.Text.Length == 0 || uxPassword.Text.Length == 0);
        }

        private void uxSubmit_Click(object sender, RoutedEventArgs e)
        {
            var window = new SecondWindow();
            Application.Current.MainWindow = window;
            Close();
            window.Show();
        }

        private void TextChangedEventHandler(object sender, TextChangedEventArgs e)
        {
            ToggleSubmit();
        }
    }
}
