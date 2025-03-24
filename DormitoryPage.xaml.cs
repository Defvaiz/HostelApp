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

namespace HostelApp
{
    /// <summary>
    /// Логика взаимодействия для DormitoryPage.xaml
    /// </summary>
    public partial class DormitoryPage : Page
    {
        public DormitoryPage()
        {
            InitializeComponent();

            // Загрузка типов общежитий
            var allTypes = HotelBase2Entities.GetContext().Тип.ToList();
            allTypes.Insert(0, new Тип { Название = "Все типы" });
            ComboType.ItemsSource = allTypes;
            ComboType.SelectedIndex = 0;

            // Настройка фильтров
            CheckActual.IsChecked = true;

            // Первоначальная загрузка данных
            UpdateDormitory();
        }

        private void UpdateDormitory()
        {
            var currentDormitory = HotelBase2Entities.GetContext().Общежитие.ToList();

            // Фильтрация по типу
            if (ComboType.SelectedIndex > 0)
            {
                var selectedType = ComboType.SelectedItem as Тип;
                currentDormitory = currentDormitory.Where(p => p.КодТипа == selectedType.Код).ToList();
            }

            // Фильтрация по названию
            if (!string.IsNullOrWhiteSpace(TBoxSearch.Text))
            {
                currentDormitory = currentDormitory.Where(p => p.Название.ToLower().Contains(TBoxSearch.Text.ToLower())).ToList();
            }

            // Фильтрация по доступности
            if (CheckActual.IsChecked == true)
            {
                currentDormitory = currentDormitory.Where(p => p.Доступность).ToList();
            }

            LViewDormitory.ItemsSource = currentDormitory;
        }

        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateDormitory();
        }

        private void ComboType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateDormitory();
        }

        private void CheckActual_Checked(object sender, RoutedEventArgs e)
        {
            UpdateDormitory();
        }
    } 
}
