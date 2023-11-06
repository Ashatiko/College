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
    /// Логика взаимодействия для PageAdminCatalog.xaml
    /// </summary>
    public partial class PageAdminCatalog : Page
    {
        public PageAdminCatalog()
        {
            InitializeComponent();
            Access.PanelMenu.Visibility = Visibility.Visible;
            Access.Logo.Visibility = Visibility.Visible;
            Access.BtnAddProduct.Visibility = Visibility.Visible;

            if (Access.Authorize.Role != 1)
            {
                Access.BtnUsers.Visibility = Visibility.Hidden;
            }
            else
            {
                Access.BtnUsers.Visibility = Visibility.Visible;
            }

            ProductsAdminView.ItemsSource = ConnectOdb.ConOdb.Product.ToList();
        }

        private void Filter_TextChanged(object sender, TextChangedEventArgs e)
        {
            string filter = NameFilter.Text.ToLower();

            var items = ProductsAdminView.Items;
            var collectionView = CollectionViewSource.GetDefaultView(items);

            collectionView.Filter = item =>
            {
                if (item is Product Name)
                {
                    return Name.Name.ToLower().Contains(filter);
                }
                else if (item is Product Desc)
                {
                    return Desc.Description.ToLower().Contains(filter);
                }
                else if (item is Product City)
                {
                    return City.City.ToLower().Contains(filter);
                }
                else if (item is Product Catogory)
                {
                    return Catogory.Category.ToLower().Contains(filter);
                }

                return false;
            };
        }

        private void BtnBooking(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Бронирование успешно произошло, в скором времени с вами свяжется менеджер для подтверждения бронирования", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BtnEdit(object sender, RoutedEventArgs e)
        {
            Access.FramePage.Navigate(new PageEdit((sender as Button).DataContext as Product));
        }
    }
}
