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
using System.Windows.Shapes;

namespace GitTest
{
    /// <summary>
    /// Interaction logic for WpfGitTest.xaml
    /// </summary>
    public partial class WpfGitTest : Window
    {
        public WpfGitTest()
        {
            InitializeComponent();
        }

        private void btnWelkom_Click(object sender, RoutedEventArgs e)
        {
            lstWelkom.Items.Add("Bienvenue");
            lstWelkom.Items.Add("Wilkommen");
            lstWelkom.Items.Add("Buenvieno");
        }
    }
}
