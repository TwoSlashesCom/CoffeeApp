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

namespace CoffeeApp
{
    /// <summary>
    /// Логика взаимодействия для CoffeeList.xaml
    /// </summary>
    public partial class CoffeeList : Page
    {
        public CoffeeList()
        {
            InitializeComponent();
        }

        private void OrderAmericano_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CoffeeAmericano.xaml", UriKind.Relative));
        }

        private void OrderCapuchino_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CoffeeCapuchino.xaml", UriKind.Relative));
        }

        private void OrderLatte_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CoffeeLatte.xaml", UriKind.Relative));
        }

        private void OrderRaf_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CoffeeRaf.xaml", UriKind.Relative));
        }

        private void OrderMocha_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CoffeeMocha.xaml", UriKind.Relative));
        }

    }
}
