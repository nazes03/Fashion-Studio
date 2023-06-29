using Fashion_Studio.Entities;
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

namespace Fashion_Studio.Pages
{
    /// <summary>
    /// Логика взаимодействия для OrdersPage.xaml
    /// </summary>
    public partial class OrdersPage : Page
    {
        Model1 context;
        public OrdersPage(Model1 _cont)
        {
            InitializeComponent();
            context = _cont;
            OrderData.ItemsSource = context.Order.ToList();
        }

        private void AddClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddOrderPage(context));
        }

        private void RemoveClick(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы точно хотите удалить заказ?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    Order ord = (sender as Hyperlink).DataContext as Order;
                    context.Order.Remove(ord);
                    context.SaveChanges();
                    OrderData.ItemsSource = context.Order.ToList();
                }
                catch
                {
                    MessageBox.Show("Ошибка");
                }
            }
        }

        private void EditClick(object sender, RoutedEventArgs e)
        {
            Order ord = (sender as Hyperlink).DataContext as Order;
            NavigationService.Navigate(new AddOrderPage(context, ord));
        }
    }
}
