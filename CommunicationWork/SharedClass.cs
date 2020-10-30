
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace CommunicationWork
{

   

    public delegate void SetTitleDelegate(string title);

    public delegate void SetSizeDelegate(int height, int width);

    class SharedClass
    {
        
        public static void SetFrame(Frame frame, Page page)
        {
            frame.Content = page;
        }

        public static void OpenNewPage(System.Windows.DependencyObject obj, Page page)
        {
            NavigationService service = NavigationService.GetNavigationService(obj);
            service.Navigate(page);
        }


    }
}
