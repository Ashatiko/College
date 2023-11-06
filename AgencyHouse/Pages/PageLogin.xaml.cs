using AgencyHouse.AppData;
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

namespace AgencyHouse.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageLogin.xaml
    /// </summary>
    public partial class PageLogin : Page
    {
        public PageLogin()
        {
            InitializeComponent();
        }
        private void BtnEnter(object sender, RoutedEventArgs e)
        {
            try
            {
                if (login.Text.Length > 0)
                {
                    if (password.Password.Length > 0)
                    {
                        var userodj = ConnectOdb.ConOdb.User.FirstOrDefault(x => x.Login == login.Text && x.Password == password.Password);
                        Access.Authorize = userodj;
                        if (userodj == null)
                        {
                            MessageBox.Show("Такого пользователя нет.", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                        else
                        {
                            switch (userodj.Role)
                            {
                                case 1:
                                    MessageBox.Show("Здравствуйте администратор " + userodj.Name, "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);                                    
                                    Access.FramePage.Navigate(new PageAdminCatalog());
                                    break;
                                case 2:
                                    MessageBox.Show("Здравствуйте менеджер " + userodj.Name, "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                                    Access.FramePage.Navigate(new PageAdminCatalog());
                                    break;
                                case 3:
                                    MessageBox.Show("Здравствуйте клиент " + userodj.Name, "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                                    Access.FramePage.Navigate(new PageCatalog());
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    else MessageBox.Show("Введите пароль", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else MessageBox.Show("Введите логин", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка. " + err.Message.ToString(), "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnEnterGuest(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Здравствуйте гость ", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            Access.FramePage.Navigate(new PageCatalog());
        }

        private void BntEditUser_Click(object sender, RoutedEventArgs e)
        {
            Access.FramePage.Navigate(new PageRegistration());
        }
    }
}
