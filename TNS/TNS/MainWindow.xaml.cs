using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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

namespace TNS
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SignIn_Btn_Click(object sender, RoutedEventArgs e)
        {
            using(Telecom_Neva_SvyazEntities db = new Telecom_Neva_SvyazEntities())
            {
                var val = db.Employees.FirstOrDefault(p => p.Номер_телефона== PhoneNumberTxb.Text && p.Пароль == PasswordTxb.Text);
                if (val != null)
                {
                    string position = string.IsNullOrEmpty(val.Positions.Должность) ? "No name" : val.Positions.Должность;
                    string userFirstName = string.IsNullOrEmpty(val.Фамилия) ? "No name" : val.Фамилия;
                    string userName = string.IsNullOrEmpty(val.Имя) ? "No name" : val.Имя;
                    MessageBox.Show($"User name: {userFirstName} {userName} \nДолжность: {position}");
                }
            }
        }

        private void Cancel_Btn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
