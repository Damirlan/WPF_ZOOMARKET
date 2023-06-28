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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {

            try
            {
                InitializeComponent();
            }
            catch
            {
                MessageBox.Show("CONNECT LOSE");
            }
        }

        private void Button_Input_Click(object sender, RoutedEventArgs e)
        {
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
            Hide();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = loginBox.Text.Trim();
            string password1 = passBox1.Password.Trim();
            string password2 = passBox2.Password.Trim();
            string email = emailBox.Text.Trim().ToLower();

            InitializeComponent();
            string ConnectDB = "server=localhost;user=root;database=qwerty;password=;";
            MySqlConnection Connection = new MySqlConnection(ConnectDB);
            Connection.Open();
            string SQL_Query = "SELECT * FROM admins";
            MySqlCommand Command = new MySqlCommand(SQL_Query, Connection);
            Connection.Close();

            if (login.Length < 5)
            {
                loginBox.ToolTip = "это поле введено некорректно";
                loginBox.Background = Brushes.DarkRed;
            }
            else if (password1.Length < 5)
            {
                passBox1.ToolTip = "это поле введено некорректно";
                passBox1.Background = Brushes.DarkRed;
            }
            else if (password1 != password2)
            {
                passBox2.ToolTip = "это поле введено некорректно";
                passBox2.Background = Brushes.DarkRed;
            }
            else if (email.Length < 5 || !email.Contains("@") || !email.Contains("."))
            {
                emailBox.ToolTip = "это поле введено некорректно";
                emailBox.Background = Brushes.DarkRed;
            }
            else
            {
                loginBox.ToolTip = "";
                loginBox.Background = Brushes.Transparent;
                passBox1.ToolTip = "";
                passBox1.Background = Brushes.Transparent;
                passBox2.ToolTip = "";
                passBox2.Background = Brushes.Transparent;
                emailBox.ToolTip = "";
                emailBox.Background = Brushes.Transparent;


                string ConnectDB1 = "server=localhost;user=root;database=qwerty;password=;";
                MySqlConnection conn = new MySqlConnection(ConnectDB1);
                conn.Open();
                string sql = "SELECT login FROM admins";
                // объект для выполнения SQL-запроса
                MySqlCommand comm = new MySqlCommand(sql, conn);
                // объект для чтения ответа сервера
                MySqlDataReader reader = comm.ExecuteReader();
                int i = 0;
                bool t = true;
                string str = "";
                while (reader.Read())
                {
                    MessageBox.Show(reader.GetString(0));

                    str += "Login: " + reader.GetString(0) + "  |  ";

                    // элементы массива [] - это значения столбцов из запроса SELECT
                    if (login == reader.GetString(0))
                    {
                        t = false;
                    }
                    Console.WriteLine(reader.GetString(0));
                    i++;
                }
                
                conn.Close();
                if (t)
                {
                    string connectionString = "server=localhost;user=root;database=qwerty;password=;";
                    // объект для установления соединения с БД
                    MySqlConnection connection = new MySqlConnection(connectionString);
                    // открываем соединение
                    connection.Open();
                    // запросы
                    // запрос вставки данных
                    string query = $"INSERT INTO admins (login, password, email) VALUES ('{login}', '{password1}', '{email}')";


                    // объект для выполнения SQL-запроса
                    MySqlCommand command = new MySqlCommand(query, connection);
                    // выполняем запрос
                    command.ExecuteNonQuery();
                    // закрываем подключение к БД
                    connection.Close();
                }
                MessageBox.Show("Всё хорошо!!");
                AuthWindow authWindow = new AuthWindow();
                authWindow.Show();
                Hide();
            }
        }
    }

}
