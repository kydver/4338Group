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

namespace _4338Project
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

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            Kuznetsova_4338 albina = new Kuznetsova_4338();
            albina.Show();
        }

        private void AidarInfoButton_Click(object sender, RoutedEventArgs e)
        {
            Salikhzyanov_4338 aidar = new Salikhzyanov_4338(); 
            aidar.Show();
        }
    }
}
