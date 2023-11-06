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
using System.Xml.Linq;

namespace AgencyHouse.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageUser.xaml
    /// </summary>
    public partial class PageUser : Page
    {
        public PageUser()
        {
            InitializeComponent();

            Users.ItemsSource = ConnectOdb.ConOdb.User.ToList();
        }

        private void BtnEdit(object sender, RoutedEventArgs e)
        {
            Access.FramePage.Navigate(new PageUserEdit((sender as Button).DataContext as User));            
        }
        private void Filter_TextChanged(object sender, TextChangedEventArgs e)
        {
            string filter = NameFilter.Text.ToLower();

            var items = Users.Items;
            var collectionView = CollectionViewSource.GetDefaultView(items);

            collectionView.Filter = item =>
            {
                if (item is User Name)
                {
                    return Name.Name.ToLower().Contains(filter);
                }
                else if (item is User login)
                {
                    return login.Login.ToLower().Contains(filter);
                }
                else if (item is User Surname)
                {
                    return Surname.Surname.ToLower().Contains(filter);
                }
                return false;
            };
        }
    }
}
