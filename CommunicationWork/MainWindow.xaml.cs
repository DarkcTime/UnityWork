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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Object testMain; 

        public MainWindow()
        {
            InitializeComponent();
            SharedClass.SetFrame(this.MainFrame, new Auth());
            testMain = DataContext; 
            
        }

        public void SetTitle(string title)
        {
            
        }       

        public static void SetSize(int height, int width)
        {
            
        }

    }
}
