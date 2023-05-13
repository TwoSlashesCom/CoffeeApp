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
    /// Логика взаимодействия для CoffeeRaf.xaml
    /// </summary>
    public partial class CoffeeRaf : Page
    {
        public CoffeeRaf()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int number = random.Next(100000, 1000000);


            var selectedItem = (TextBlock)SyrupBox.SelectedItem;
            string message = string.Format("Заказ № {0}\nНаименование: {1}\nОбъем: {3} \nСахар: {4}\nСироп: {5}\nЦена: {2}руб.", number, CoffeeName.Text, TotalPrice.Text, VolumeBox.Text, SugarBool.Text, selectedItem.Text);
            MessageBox.Show(message);

            string order = $"{number}, {CoffeeName.Text},{VolumeBox.Text},{SugarBool.Text},{selectedItem.Text},{TotalPrice.Text}";

            File.AppendAllText("D:\\CoffeeApp\\CoffeeApp\\OrderData.txt", $"{order}\n");
            NavigationService.Navigate(new Uri("/CoffeeList.xaml", UriKind.Relative));

        }

        private void ComboBoxVolume_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = (TextBlock)VolumeBox.SelectedItem;
            string volume = selectedItem.Text;

            if (volume == "0.35л")
            {
                TotalPrice.Text = "230";
            }

            if (volume == "0.45л")
            {
                TotalPrice.Text = "260";
            }
        }

        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            SugarBool.Text = "Добавлен";
        }

        private void ToggleButton_Unchecked(object sender, RoutedEventArgs e)
        {
            SugarBool.Text = "Без сахара";
        }
        private void SyrupBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = (TextBlock)SyrupBox.SelectedItem;
            if (selectedItem != null)
            {
                var newText = selectedItem.ToString();
                if (TotalPrice.Text == "230")
                {
                    TotalPrice.Text = "250";
                }

                if (TotalPrice.Text == "260")
                {
                    TotalPrice.Text = "280";
                }
            }
        }
    }
}
