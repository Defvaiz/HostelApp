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
    /// Логика взаимодействия для HostelPage.xaml
    /// </summary>
    public partial class HostelPage : Page
    {
        public HostelPage()
        {
            InitializeComponent();
            //DGridHostel.ItemsSource = HotelBase2Entities.GetContext().Комната.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage((sender as Button).DataContext as Комната));
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage(null));
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var комнатаForRemoving = DGridHostel.SelectedItems.Cast<Комната>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {комнатаForRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    HotelBase2Entities.GetContext().Комната.RemoveRange(комнатаForRemoving);
                    HotelBase2Entities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    DGridHostel.ItemsSource = HotelBase2Entities.GetContext().Комната.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                HotelBase2Entities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGridHostel.ItemsSource = HotelBase2Entities.GetContext().Комната.ToList();
            }
        }
    }
}
