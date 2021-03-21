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

namespace Pharm
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

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            if (FrMain.CanGoBack)
                FrMain.GoBack();
        }

        private void BtnGo_Click(object sender, RoutedEventArgs e)
        {
            if (FrMain.CanGoForward)
                FrMain.GoForward();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            new Windows.Authorization().Show();
            Close();
        }
    }
}