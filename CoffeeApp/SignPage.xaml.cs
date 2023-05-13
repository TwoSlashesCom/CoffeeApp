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
using System.IO;

namespace CoffeeApp
{
    /// <summary>
    /// Логика взаимодействия для SignPage.xaml
    /// </summary>
    public partial class SignPage : Page
    {
        public SignPage()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            string login = Login.Text;
            string password = Password.Password;
           
            string[] lines = File.ReadAllLines("D:\\CoffeeApp\\CoffeeApp\\UsersData.txt");

            bool isUserFound = false;
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 2 && parts[0] == login && parts[1] == password)
                {
                    isUserFound = true;
                    break;
                }
            }

            if (isUserFound)
            {
                NavigationService.Navigate(new Uri("/CoffeeList.xaml", UriKind.Relative));
                MessageBox.Show("Добро пожаловать!");
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }
      
        private void HrefJoinButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/JoinPage2.xaml", UriKind.Relative));
        }
    }
}
