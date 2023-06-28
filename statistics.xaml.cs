using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

namespace SimpleApp
{
    /// <summary>
    /// Логика взаимодействия для statistics.xaml
    /// </summary>
    public partial class statistics : Window
    {
        public statistics(DateTime? date1, DateTime? date2)
        {
            InitializeComponent();
            MessageBox.Show(date1.Value.Date.ToShortDateString());

            string ConnectDB1 = "server=localhost;user=root;database=qwerty;password=;";

            string str1 = date1.ToString();
            string str2 = date2.ToString();
            //string sql = String.Format(@"SELECT product.name_product, brend.name_brend, purchases.date_of_purchase, typeofproduct.name_top, typeofanimal.name_type
            string sql = String.Format(@"SELECT product.name_product, COUNT(product.name_product), AVG(marks.mark)
                FROM marks
                JOIN purchases ON purchases.id = marks.id_purchases
                JOIN product ON product.id = purchases.id_product
                JOIN brend ON brend.id = product.id_brend
                JOIN breedofanimal ON breedofanimal.id = product.id_animal
                JOIN typeofanimal ON typeofanimal.id = breedofanimal.id_type
                JOIN typeofproduct ON typeofproduct.id = product.id_top
                WHERE date_of_purchase > '{0}'
                GROUP BY name_product", str1);
            //WHERE date_of_purchase > '{0}' AND date_of_purchase < '{1}'", date1.ToString(), date2.ToString());
            //WHERE date_of_purchase > { 0} AND date_of_purchase< { 1}", date1.ToString(), date2.ToString());

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
        private void Search_Click(object sender, RoutedEventArgs e)
        {
            Search_page userPage = new Search_page();
            userPage.Show();
            Hide();
        }

        private void Main_Click(object sender, RoutedEventArgs e)
        {
            UserPageWindow userPage = new UserPageWindow();
            userPage.Show();
            Hide();
        }
    }
}
