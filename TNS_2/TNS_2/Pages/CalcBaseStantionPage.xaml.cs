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

namespace TNS_2.Pages
{
    /// <summary>
    /// Логика взаимодействия для CalcBaseStantionPagexaml.xaml
    /// </summary>
    public partial class CalcBaseStantionPagexaml : Page
    {
        public CalcBaseStantionPagexaml()
        {
            InitializeComponent();
        }

        private void Vasileostrovsky_Btn_Click(object sender, RoutedEventArgs e)
        {
            double l, r, n, c, d, k, s;
           
            s = 16.64;
            k = 1.21;
            r = Math.Sqrt((s * Math.PI) / Math.PI);
            d = 2 * r;
            l = k * Math.Pow(Math.Sqrt(s / Math.PI) / r, 2);
            c = Math.Pow(d, (5 / 2)) + +Math.Pow(d, (3 / 2)) + Math.Pow(d, (1 / 2));
            n = l / c;

            MessageBox.Show($"Количество станций в данном районе: {n}");
        }

        private void Petrogradsky_Btn_Click(object sender, RoutedEventArgs e)
        {
            double l, r, n, c, d, k, s;

            s = 24;
            k = 0.9;
            r = Math.Sqrt((s * Math.PI) / Math.PI);
            d = 2*r;
            l = k * Math.Pow(Math.Sqrt(s / Math.PI) / r, 2);
            c = Math.Pow(d,(5/2)) + +Math.Pow(d, (3 / 2)) + Math.Pow(d, (1 / 2));
            n = l / c;

            MessageBox.Show($"Количество станций в данном районе: {n}");
        }

        private void Admiralteisky_Btn_Click(object sender, RoutedEventArgs e)
        {
            double l, r, n, c, d, k, s;

            s = 13.82;
            k = 1.21;
            r = Math.Sqrt((s * Math.PI) / Math.PI);
            d = 2 * r;
            l = k * Math.Pow(Math.Sqrt(s / Math.PI) / r, 2);
            c = Math.Pow(d, (5 / 2)) + +Math.Pow(d, (3 / 2)) + Math.Pow(d, (1 / 2));
            n = l / c;

            MessageBox.Show($"Количество станций в данном районе: {n}");
        }

        private void Back_Btn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
