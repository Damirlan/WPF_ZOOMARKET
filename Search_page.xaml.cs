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

namespace SimpleApp
{
    /// <summary>
    /// Логика взаимодействия для Search_page.xaml
    /// </summary>
    public partial class Search_page : Window
    {
        public Search_page()
        {
            InitializeComponent();
        }
        private void back_Click(object sender, RoutedEventArgs e)
        {
            UserPageWindow userPage = new UserPageWindow();
            userPage.Show();
            Hide();
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            DateTime? selectedDate1 = datePicker1.SelectedDate;
            DateTime? selectedDate2 = datePicker2.SelectedDate;
            statistics userPage = new statistics(selectedDate1, selectedDate2);

            userPage.Show();
            Hide();
        }
    }
}
