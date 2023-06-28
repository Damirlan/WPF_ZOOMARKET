using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
using MySql.Data.MySqlClient;

namespace SimpleApp
{
    /// <summary>
    /// Логика взаимодействия для UserPageWindow.xaml
    /// </summary>
    public partial class UserPageWindow : Window
    {
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            deleteProduct addProduct = new deleteProduct();
            addProduct.Show();
            Hide();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 addProduct = new Window1();
            addProduct.Show();
            Hide();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            Search_page search = new Search_page();
            search.Show();
            Hide();
        }

        public UserPageWindow()
        {
            InitializeComponent();
            string ConnectDB1 = "server=localhost;user=root;database=qwerty;password=;";

            

            string sql = @"SELECT product.name_product, brend.name_brend, breedofanimal.name_breed, typeofproduct.name_top, typeofanimal.name_type 
                FROM product
                JOIN brend ON brend.id = product.id_brend
                JOIN breedofanimal ON breedofanimal.id = product.id_animal
                JOIN typeofanimal ON typeofanimal.id = breedofanimal.id_type
                JOIN typeofproduct ON typeofproduct.id = product.id_top";
            
            using (MySqlConnection connection = new MySqlConnection(ConnectDB1))
            {
                connection.Open();
                using (MySqlCommand cmdSel = new MySqlCommand(sql, connection))
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmdSel);
                    da.Fill(dt);
                    adminGrid.ItemsSource = dt.DefaultView;
                }
                connection.Close();
            }
        }
    }
}
