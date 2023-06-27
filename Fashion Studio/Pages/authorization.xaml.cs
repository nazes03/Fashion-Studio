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
using System.Windows.Threading;

namespace Fashion_Studio.Pages
{
    /// <summary>
    /// Логика взаимодействия для authorization.xaml
    /// </summary>
    public partial class authorization : Page
    {
        Model1 context;
        DispatcherTimer timer;
        Window window;
        public authorization(Model1 cont, Window w)
        {
            InitializeComponent();
            context = cont;
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 15);
            timer.Tick += Timer_Tick;
            window = w;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            buttonEnter.IsEnabled = true;
            timer.Stop();
        }

        int countClick = 0;
        private void EnterClick(object sender, RoutedEventArgs e)
        {
            countClick++;
            string login = LoginBox.Text;
            string password = PasswordBox.Password;
            Users user = context.Users.Find(login);
            if (user!=null)
            {
                if (user.Password.Equals(password))
                {
                    NavigationService.Navigate(new MainMenu(context, window));
                }
                else
                {
                    MessageBox.Show("Неверный пароль");
                    if (countClick >= 3)
                    {
                        buttonEnter.IsEnabled = false;
                        timer.Start();
                    }
                }
            }
            else
            {
                MessageBox.Show("Такого пользователя не существует");
                if (countClick >= 3)
                {
                    buttonEnter.IsEnabled = false;
                    timer.Start();
                }
            }
        }

        private void RegistrationClick(object sender, RoutedEventArgs e)
        {
            registration regWindow = new registration(context);
            regWindow.Show();
        }
    }
}
