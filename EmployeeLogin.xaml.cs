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
    /// Логика взаимодействия для EmployeeLogin.xaml
    /// </summary>
    public partial class EmployeeLogin : Window
    {
        public EmployeeLogin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EmployeeMenu w5 = new EmployeeMenu();
            Hide();
            w5.Show();
        }
    }
}
