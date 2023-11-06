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
    /// Логика взаимодействия для PageUserEdit.xaml
    /// </summary>
    public partial class PageUserEdit : Page
    {
        private readonly User _user;
        public PageUserEdit(User user)
        {
            InitializeComponent();
            _user = user;
            role.ItemsSource = ConnectOdb.ConOdb.UserRole.ToList();

            name.Text = _user.Name;
            surname.Text = _user.Surname;
            login.Text = _user.Login;           
        }

        private void BtnRemove(object sender, RoutedEventArgs e)
        {
            User prod = ConnectOdb.ConOdb.User.FirstOrDefault(x => x.Id == Access.Authorize.Id);
            ConnectOdb.ConOdb.User.Remove(prod);
            ConnectOdb.ConOdb.SaveChanges();

            MessageBox.Show("Данные были успешно измененны.", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);

            Access.FramePage.Navigate(new PageCatalog());
        }

        private void BtnEditUser(object sender, RoutedEventArgs e)
        {
            try
            {
                int userRole =3;
                switch (role.Text)
                {
                    case "Администратор":
                        userRole = 1;
                        break;
                    case "Менеджер":
                        userRole=2;
                        break;
                    case "Пользователь":
                        userRole = 3;
                        break;
                    default:
                        break;
                }
                IEnumerable<User> users = ConnectOdb.ConOdb.User.Where(x => x.Id == _user.Id).AsEnumerable().Select(x =>
                {
                    x.Name = name.Text;
                    x.Surname = surname.Text;
                    x.Login = login.Text;
                    x.Role = userRole;
                    return x;
                });
                foreach (var value in users)
                {
                    ConnectOdb.ConOdb.Entry(value).State = System.Data.Entity.EntityState.Modified;
                }
                ConnectOdb.ConOdb.SaveChanges();
                MessageBox.Show("Данные были успешно изменены", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Введите корректные значения", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
