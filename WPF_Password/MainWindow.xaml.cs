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
using Bogus;

namespace WPF_Password
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        private void Passwod_Click(object sender, RoutedEventArgs e)
        {
            SendTextBox.Visibility = Visibility.Visible;
            SendTextBox.Focus();

            btnSend.Visibility = Visibility.Visible;
            btnSend.Focus();
        }

        private void Send_Click(object sender, RoutedEventArgs e)
        {
            PasswodTextBox.Text = SendTextBox.Text;
        }

        private void AutoPasswod_Click(object sender, RoutedEventArgs e)
        {
            var faker = new Faker();
            string password = faker.Internet.Password();
            PasswodTextBox.Text = password;
        }
    }
}
