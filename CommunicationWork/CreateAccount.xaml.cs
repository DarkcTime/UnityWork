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

namespace CommunicationWork
{
    /// <summary>
    /// Interaction logic for CreateAccount.xaml
    /// </summary>
    public partial class CreateAccount : Page
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void CreateUserClick(object sender, RoutedEventArgs e)
        {
            SharedClass.OpenNewPage(this, new MainMenu());
        }

        private void BackClick(object sender, RoutedEventArgs e)
        {
            SharedClass.OpenNewPage(this, new CreateAccount());
        }
    }
}
