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
    /// Логика взаимодействия для PageRegistration.xaml
    /// </summary>
    public partial class PageRegistration : Page
    {
        public PageRegistration()
        {
            InitializeComponent();
        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            if (name.Text.Length > 0)
            {
                if (surname.Text.Length > 0)
                {
                    if (login.Text.Length > 0)
                    {
                        if (password.Text.Length > 0)
                        {
                            if (ConnectOdb.ConOdb.User.Count(x => x.Login == login.Text) > 0)
                            {
                                MessageBox.Show("Данный логин уже существует.", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
                            }
                            else
                            {
                                User user = new User()
                                {
                                    Name = name.Text,
                                    Surname = surname.Text,                                    
                                    Login = login.Text,
                                    Password = password.Text,
                                    Role = 3

                                };
                                ConnectOdb.ConOdb.User.Add(user);
                                ConnectOdb.ConOdb.SaveChanges();
                                MessageBox.Show("Данные успешно сохранены.", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                                Access.FramePage.Navigate(new PageCatalog());
                            }
                        }
                        else
                        {
                            MessageBox.Show("Введите пароль.", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите логин.", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Введите фамилию.", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("Введите имя.", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void BtnEnterGuest(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Здравствуйте гость.", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            Access.FramePage.Navigate(new PageCatalog());
        }

        private void pasrepeate_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (pasrepeate.Password != password.Text)
            {
                btnreg.IsEnabled = false;
                pasrepeate.Background = Brushes.LightCoral;
                pasrepeate.BorderBrush = Brushes.Red;
            }
            else
            {
                btnreg.IsEnabled = true;
                pasrepeate.Background = Brushes.LightGreen;
                pasrepeate.BorderBrush = Brushes.Green;
            }
        }

        private void password_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (pasrepeate.Password != password.Text)
            {
                btnreg.IsEnabled = false;
                pasrepeate.Background = Brushes.LightCoral;
                pasrepeate.BorderBrush = Brushes.Red;
            }
            else
            {
                btnreg.IsEnabled = true;
                pasrepeate.Background = Brushes.LightGreen;
                pasrepeate.BorderBrush = Brushes.Green;
            }
        }

        private void BtnBack(object sender, RoutedEventArgs e)
        {
            Access.FramePage.GoBack();
        }
    }
}
