﻿using System;
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
            DGridHostel.ItemsSource = HotelBase2Entities.GetContext().Комната.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage());
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage());
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
