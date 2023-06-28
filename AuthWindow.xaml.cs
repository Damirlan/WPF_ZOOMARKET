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
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e) {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Hide();
        }

        private void Button_Auth_Click(object sender, RoutedEventArgs e)
        {
            string login = loginBox.Text.Trim();
            string password1 = passBox1.Password.Trim();

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
            else
            {
                loginBox.ToolTip = "";
                loginBox.Background = Brushes.Transparent;
                passBox1.ToolTip = "";
                passBox1.Background = Brushes.Transparent;

                string ConnectDB1 = "server=localhost;user=root;database=qwerty;password=;";
                MySqlConnection conn = new MySqlConnection(ConnectDB1);
                conn.Open();
                string sql = "SELECT login, password FROM admins";
                // объект для выполнения SQL-запроса
                MySqlCommand comm = new MySqlCommand(sql, conn);
                // объект для чтения ответа сервера
                MySqlDataReader reader = comm.ExecuteReader();
                bool t = false;
                string str = "";
                while (reader.Read())
                {


                    // элементы массива [] - это значения столбцов из запроса SELECT
                    if (login == reader.GetString(0) && password1 == reader.GetString(1))
                    {
                        t = true;
                    }
                }
                conn.Close();
                if(t)
                {
                    MessageBox.Show("Вы вошли!!!");
                    UserPageWindow userPageWindow = new UserPageWindow();
                    userPageWindow.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("(((((");
                }
            }
        }
    }
}
