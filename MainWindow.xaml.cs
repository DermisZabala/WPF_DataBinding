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

namespace WPF_DataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /*private void OrigenAltura_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(double.TryParse(OrigenAltura.Text, out double NuevaAltura))
            {
                btn.Height = NuevaAltura;
            }
        }

        private void OrigenAnchura_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(double.TryParse(OrigenAnchura.Text, out double NuevaAnchura))
            {
                btn.Width = NuevaAnchura;
            }
        }*/
    }
}
