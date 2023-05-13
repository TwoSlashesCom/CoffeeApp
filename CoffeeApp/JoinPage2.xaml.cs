using System;
using System.Collections.Generic;
using System.Configuration;
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
    /// Логика взаимодействия для JoinPage2.xaml
    /// </summary>
    public partial class JoinPage2 : Page 
    {

        public JoinPage2()
        {
            InitializeComponent();

        }

        private void JoinInButton_Click(object sender, RoutedEventArgs e)
        {
            string login = Login.Text;
            string password = Password.Password;
            string rep_password = Repeat_Password.Password;


            if (login.Length != 11)
            {
                Login.ToolTip = "Некорректные данные!";
                Login.Foreground = Brushes.Red;
            }

            else if (password.Length < 8)
            {
                Password.ToolTip = "Пароль слишком короткий!";
                Password.Foreground = Brushes.Red;
            }

            else if (password != rep_password)
            {
                Repeat_Password.ToolTip = "Пароли не совпадают!";
                Repeat_Password.Foreground = Brushes.Red;
            }

            else
            {
                Login.ToolTip = "";
                Login.Foreground = Brushes.SaddleBrown;
                Password.ToolTip = "";
                Password.Foreground = Brushes.SaddleBrown;
                Repeat_Password.ToolTip = "";
                Repeat_Password.Foreground = Brushes.SaddleBrown;

                string user = $"{login},{password}";

                File.AppendAllText("D:\\CoffeeApp\\CoffeeApp\\UsersData.txt", $"{user}\n");

                MessageBox.Show("Регистрация прошла успешно!");
            }

            NavigationService.Navigate(new Uri("/SignPage.xaml", UriKind.Relative));
        }
}
}
