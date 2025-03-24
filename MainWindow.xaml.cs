using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new DormitoryPage());
            Manager.MainFrame = MainFrame;

            //ImportHostel();

        }

        private void ImportHostel()
        {
            var fileData = File.ReadAllLines(@"C:\Users\Максим\Desktop\Отели.txt");
            var images = Directory.GetFiles(@"C:\Users\Максим\Desktop\Фото");

            foreach (var line in fileData)
            {
                var data = line.Split('\t');
                var tempHostel = new Общежитие
                {
                    Название = data[0].Replace("\"", ""),
                    КоличествоМест = int.Parse(data[2]),
                    Цена = int.Parse(data[3]),
                    Доступность = (data[4] == "0") ? false : true

                };

                foreach (var Тип in data[5].Replace("\"", "").Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries))
                {
                    var currentType = HotelBase2Entities.GetContext().Тип.FirstOrDefault(p => p.Название == Тип);
                    if (currentType == null)
                    {
                        currentType = new Тип()
                        {
                            Название = Тип
                        };
                        HotelBase2Entities.GetContext().Тип.Add(currentType);
                    }
                    tempHostel.Тип = currentType;

                  //  currentType.Общежитие.Add(tempHostel);
                }

                try
                {
                    tempHostel.Фото = File.ReadAllBytes(images.FirstOrDefault(p => p.Contains(tempHostel.Название)));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
               var entry =  HotelBase2Entities.GetContext().Entry(tempHostel);
                HotelBase2Entities.GetContext().Общежитие.Add(tempHostel);
                HotelBase2Entities.GetContext().SaveChanges();
            }
        }


        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            if (MainFrame.CanGoBack)
            {
                BtnBack.Visibility = Visibility.Visible;
            }
            else
            {
                BtnBack.Visibility = Visibility.Hidden;
            }
        }
    }
}
