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

namespace ООО_Посуда
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void EmployeeAuth_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            EmployeeLogin w3 = new EmployeeLogin();
            Hide();
            w3.Show();
        }

        private void Reg_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Registration w1 = new Registration();
            Hide();
            w1.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Menu w4 = new Menu();
            Hide();
            w4.Show();
        }

        private void GuestLogin_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Menu w4 = new Menu();
            Hide();
            w4.Show();
        }
    }
}
