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
using Entity;
using Data;
using Business;

namespace Capas
{
    public partial class MainWindow : Window
    {
        string connectionString = "Data Source=LAB1504-06\\SQLEXPRESS;Initial Catalog=Lab07;User ID=Danny;Password=123456";
        public MainWindow()
        {
            InitializeComponent();
            List<Product> products = DProduct.GetAll();


            dgSimple.ItemsSource = products;
        }

        private void McDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
