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
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Page
    {
        private Комната _currentRoom = new Комната();
        public AddEditPage()
        {
            InitializeComponent();
            DataContext = _currentRoom;
            ComboNames.ItemsSource = HotelBase2Entities.GetContext().Жильцы.ToList();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (_currentRoom.Номер < 1)
                errors.AppendLine("Укажите номер комнаты");
            if (_currentRoom.СвободныеМеста > 5)
                errors.AppendLine("Укажите количество свободных мест");
        }
    }
}
