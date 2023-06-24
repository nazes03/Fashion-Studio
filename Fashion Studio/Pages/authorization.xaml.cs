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
    /// Логика взаимодействия для authorization.xaml
    /// </summary>
    public partial class authorization : Page
    {
        Model1 context;
        public authorization(Model1 cont)
        {
            InitializeComponent();
            context = cont;
        }

        private void EnterClick(object sender, RoutedEventArgs e)
        {
            string login = LoginBox.Text;
            string password = PasswordBox.Password;
            Users user = context.Users.Find(login);
            if (user!=null)
            {
                if (user.Password.Equals(password))
                {
                    MessageBox.Show("Успешная авторизация");
                }
                else
                {
                    MessageBox.Show("Неверный пароль");
                }
            }
            else
            {
                MessageBox.Show("Такого пользователя не существует");
            }
        }

        private void RegistrationClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
