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
    /// Логика взаимодействия для PageProductAdd.xaml
    /// </summary>
    public partial class PageProductAdd : Page
    {
        public PageProductAdd()
        {
            InitializeComponent();
        }
        private void BtnProductAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(cost.Text) > 0)
                {
                    Product product = new Product()
                    {                        
                        Category = category.Text,
                        CostDay = Convert.ToDecimal(cost.Text),
                        Description = description.Text,                        
                        Name = name.Text,
                        Image = photo.Text,
                        City = city.Text
                    };
                    ConnectOdb.ConOdb.Product.Add(product);
                    ConnectOdb.ConOdb.SaveChanges();
                    MessageBox.Show("Данные успешно сохранены.", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                    Access.FramePage.Navigate(new PageCatalog());
                }
                else
                {
                    MessageBox.Show("Цена не может быть отрицательной.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Введите корректные значения.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
