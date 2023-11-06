using AgencyHouse.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
    /// Логика взаимодействия для PageEdit.xaml
    /// </summary>
    public partial class PageEdit : Page
    {
        private readonly Product _localProduct;
        public PageEdit(Product product)
        {
            InitializeComponent();           

            name.Text = product.Name;
            cost.Text = Convert.ToString(product.CostDay);
            description.Text = product.Description;
            category.Text = product.Category;            
            photo.Text = product.Image;


            _localProduct = product;
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                IEnumerable<Product> products = ConnectOdb.ConOdb.Product.Where(x => x.Id == _localProduct.Id).AsEnumerable().Select(x =>
                {
                    x.Name = name.Text;                    
                    x.Description = description.Text;
                    x.CostDay = Convert.ToDecimal(cost.Text);
                    x.Category = category.Text;
                    x.Image = photo.Text;                   
                    return x;
                });
                if (Convert.ToDecimal(cost.Text) > 0)
                {
                    foreach (var prod in products)
                    {
                        ConnectOdb.ConOdb.Entry(prod).State = System.Data.Entity.EntityState.Modified;
                    }
                    ConnectOdb.ConOdb.SaveChanges();
                    MessageBox.Show("Данные были успешно изменены", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Цена не может быть отрицательной", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Введите корректные значения", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ConnectOdb.ConOdb.Product.Remove(_localProduct);
                MessageBox.Show("Данные были успешно удалены", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                Access.FramePage.Navigate(new PageCatalog());
            }
            catch (Exception)
            {
            }

        }
    }
}
