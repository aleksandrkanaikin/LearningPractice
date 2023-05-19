using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using static TNS.Timer;

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

        TeleconNevaEntities db = new TeleconNevaEntities();
        Users user = new Users();
        private void SignIn_Btn_Click(object sender, RoutedEventArgs e)
        {
            CheckingTheAccessCode();          
        }

        private void Cancel_Btn_Click(object sender, RoutedEventArgs e)
        {
            PhoneNumberTxb.Clear();
            PasswordTxb.Clear();
            ConfirmCode.Clear();
        }

        private void PhoneNumberTxb_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Key != Key.Enter) return;
            var num = Convert.ToInt32(PhoneNumberTxb.Text);
            user = db.Users.FirstOrDefault(p => p.Номер == num);
            if(user == null) MessageBox.Show("Не верный номер пользователя"); ;
        }

        private void PasswordTxb_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key != Key.Enter) return;
            if(user != null)
            {
                if(user.Пароль == PasswordTxb.Text)
                {
                    ConfCode();
                }
                else MessageBox.Show("Не верный номер пользователя");
            }
        }

        private void UpdateCode_Btn_Click(object sender, RoutedEventArgs e)
        {
            ConfCode();
        }

        private void ConfCode()
        {
            MessageBox.Show("Код доступа = " + Convert.ToString(Manager.CodVhoda) + " введите его в течение 10 секунд. " +
                            "\nВ случае неудачи нажмите на кнопку рядом с полем ввода кода");
            ShutdownTimer _timer = new ShutdownTimer(10);
            _timer.Run();
        }

        private void CheckingTheAccessCode()
        {
            if (ConfirmCode.Text == Convert.ToString(Manager.CodVhoda))
            {
                MessageBox.Show($"{user.Фамилия} {user.Имя} {user.Отчество} \n{user.Роль}");
            }
            else
            {
                MessageBox.Show("Не верный код доступа");
            }
        }
    }
}
