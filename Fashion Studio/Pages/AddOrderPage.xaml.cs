﻿using Fashion_Studio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace Fashion_Studio.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddOrderPage.xaml
    /// </summary>
    public partial class AddOrderPage : Page
    {
        Model1 context;
        Order order;
        public AddOrderPage(Model1 c)
        {
            InitializeComponent();
            context = c;
        }
        public AddOrderPage(Model1 c, Order ord)
        {
            InitializeComponent();
            context = c;
            order = ord;
        }

        private void CancelClick(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void AddClick(object sender, RoutedEventArgs e)
        {
            Order ord = new Order()
            {
                IdOrder = Convert.ToInt32(IdOrderBox.Text),
                IdClient = Convert.ToInt32(IdClientBox.Text),
                IdModel = Convert.ToInt32(IdModelBox.Text),
                IdCloth = Convert.ToInt32(IdClothBox.Text),
                idDressMaker = Convert.ToInt32(IdDressMakerBox.Text),
                DateOfStart = Convert.ToDateTime(DateOfStartBox.Text),
                DateOfEnd = Convert.ToDateTime(DateOfEndBox.Text)
            };
            context.Order.Add(ord);
            context.SaveChanges();
            NavigationService.Navigate(new AddOrderPage(context));
        }
    }
}
