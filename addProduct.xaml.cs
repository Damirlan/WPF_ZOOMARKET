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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private void add_Click(object sender, RoutedEventArgs e)
        {
            string nameProd = nameProduct.Text.Trim();
            string nameAnimal1 = nameAnimal.Text;
            string nameTop1 = nameTop.Text;
            string nameBrend1 = nameBrend.Text;
            int idAnimal = 0, idTop = 0, idBrend = 0;

            switch (nameAnimal1)
            {
                case "CentralAsian":
                    idAnimal = 1;
                    break;
                case "Red":
                    idAnimal = 2;
                    break;
                case "American":
                    idAnimal = 3;
                    break;
                case "African":
                    idAnimal = 4;
                    break;
                case "French":
                    idAnimal = 5;
                    break;
                case "Portuguese":
                    idAnimal = 6;
                    break;
                case "Scottish":
                    idAnimal = 7;
                    break;
                case "English":
                    idAnimal = 8;
                    break;
            }

            switch (nameTop1)
            {
                case "food":
                    idTop = 1;
                    break;
                case "clothes":
                    idTop = 2;
                    break;
                case "medicines":
                    idTop = 3;
                    break;
                case "accessories":
                    idTop = 4;
                    break;
            }

            switch (nameBrend1)
            {
                case "royalcanin":
                    idBrend = 1;
                    break;
                case "acana":
                    idBrend = 2;
                    break;
                case "proplan":
                    idBrend = 3;
                    break;
                case "purina":
                    idBrend = 4;
                    break;
                case "catchow":
                    idBrend = 5;
                    break;
            }
            if (nameProd != "" && idAnimal != 0 && idTop != 0 && idBrend != 0)
            {
                string connectionString = "server=localhost;user=root;database=qwerty;password=;";
                // объект для установления соединения с БД
                MySqlConnection connection = new MySqlConnection(connectionString);
                // открываем соединение
                connection.Open();
                // запросы
                // запрос вставки данных
                string query = $"INSERT INTO product (name_product, id_animal, id_top, id_brend) VALUES ('{nameProd}', '{idAnimal}', '{idTop}', '{idBrend}')";


                // объект для выполнения SQL-запроса
                MySqlCommand command = new MySqlCommand(query, connection);
                // выполняем запрос
                command.ExecuteNonQuery();
                // закрываем подключение к БД
                connection.Close();
                UserPageWindow userPage = new UserPageWindow();
                userPage.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("(((((");
            }
        }
        private void back_Click(object sender, RoutedEventArgs e)
        {
            UserPageWindow userPage = new UserPageWindow();
            userPage.Show();
            Hide();
        }

        public Window1()
        {
            InitializeComponent();
        }
    }
}
