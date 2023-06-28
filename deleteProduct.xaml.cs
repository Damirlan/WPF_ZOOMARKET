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
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

namespace SimpleApp
{
    /// <summary>
    /// Логика взаимодействия для deleteProduct.xaml
    /// </summary>
    public partial class deleteProduct : Window
    {
        public deleteProduct()
        {
            InitializeComponent();
            string ConnectDB1 = "server=localhost;user=root;database=qwerty;password=;";
            MySqlConnection conn = new MySqlConnection(ConnectDB1);
            conn.Open();
            string sql = "SELECT id FROM product";
            // объект для выполнения SQL-запроса
            MySqlCommand comm = new MySqlCommand(sql, conn);
            // объект для чтения ответа сервера
            MySqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                //MessageBox.Show(reader.GetString(0));
                nameProd1.Items.Add(reader.GetString(0));
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            UserPageWindow userPage = new UserPageWindow();
            userPage.Show();
            Hide();
        }
        private void del_Click(object sender, RoutedEventArgs e)
        {
            
            string idProd1 = nameProd1.Text;
            string connstr = "server=localhost;user=root;database=qwerty;password=;";
            MySqlConnection conn = new MySqlConnection(connstr);
            string sql_registrUser = $"DELETE FROM product WHERE id = {idProd1}";
            MySqlCommand comm_registr = new MySqlCommand(sql_registrUser, conn);
        }
    }
}
