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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TNS_2.Pages;

namespace TNS_2
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
        private void Clients_Btn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new SubscribersPage());
        }

        private void EquipmentControl_Btn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new StatusControlPage());
        }

        private void Assets_Btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Billing_Btn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new BillingPage());
        }

        private void Support_Btn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new UserSupportPage());
        }

        private void UsersComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CRM_Btn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new CRMPage());
        }
    }
}
