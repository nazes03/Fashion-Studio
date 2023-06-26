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
using System.Windows.Shapes;

namespace Fashion_Studio.Pages
{
    /// <summary>
    /// Логика взаимодействия для registration.xaml
    /// </summary>
    public partial class registration : Window
    {
        Model1 context;
        public registration(Model1 cont)
        {
            InitializeComponent();
            context = cont;
        }

        private void RegClick(object sender, RoutedEventArgs e)
        {
            Users users = new Users()
            {
                Name = NameBox.Text,
                Post = PostBox.Text,
                Service_number = SNumberBox.Text,
                Login = LoginBox.Text,
                Password = PasswordBox.Password               
            };
            context.Users.Add(users);
            context.SaveChanges();
            this.Close();
        }
    }
}
