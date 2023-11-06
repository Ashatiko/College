using AgencyHouse.AppData;
using AgencyHouse.Pages;
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

namespace AgencyHouse
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();            

            Access.PanelMenu = menu;
            Access.FramePage = FrmMain;
            Access.Logo = logo;
            Access.BtnUsers = usersBtn;
            Access.BtnAddProduct = addProductBtn;
            FrmMain.Navigate(new PageLogin());
        }

        private void BtnExit(object sender, RoutedEventArgs e)
        {
            Access.PanelMenu.Visibility = Visibility.Hidden;
            Access.Logo.Visibility = Visibility.Hidden;
            Access.FramePage.Navigate(new PageLogin());
        }

        private void BtnProduct(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Access.Authorize != null && Access.Authorize.Role == 1 )
                    Access.FramePage.Navigate(new PageAdminCatalog());
                else
                    Access.FramePage.Navigate(new PageCatalog());
            }
            catch (Exception)
            {

            }
        }

        private void BtnProductAdd(object sender, RoutedEventArgs e)
        {
            Access.FramePage.Navigate(new PageProductAdd());
        }

        private void btnUsers(object sender, RoutedEventArgs e)
        {
            Access.FramePage.Navigate(new PageUser());
        }
    }
}
