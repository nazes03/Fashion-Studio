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
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        Window Window;
        Model1 _context;
        public MainMenu(Model1 context, Window window)
        {
            InitializeComponent();
            Window = window;
            _context = context;
        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            Window.Close();
        }

        private void ModelClick(object sender, RoutedEventArgs e)
        {
            MainMenuFrame.Navigate(new OrdersPage());
        }

        private void ClothClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
