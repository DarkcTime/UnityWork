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

namespace CommunicationWork
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        public MainMenu()
        {
            InitializeComponent();
            SharedClass.SetFrame(this.ContentFrame, new ListUsers());
        }


        private void User_Click(object sender, RoutedEventArgs e)
        {
            PopupUser.IsOpen = true;
        }

        private void UserAccount_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UserLogOut_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
