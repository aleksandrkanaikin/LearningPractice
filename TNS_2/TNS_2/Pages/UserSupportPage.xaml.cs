﻿using System;
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
    /// Логика взаимодействия для UserSupportPage.xaml
    /// </summary>
    public partial class UserSupportPage : Page
    {
        TeleconNevaEntities db = new TeleconNevaEntities();

        public UserSupportPage()
        {
            InitializeComponent();

            SupportDataGrid.ItemsSource = db.Applications.ToList();
        }
    }
}
