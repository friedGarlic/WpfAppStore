using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfApp.UserControls
{
    /// <summary>
    /// Interaction logic for AppsViewer.xaml
    /// </summary>
    public partial class AppsViewer : UserControl
    {
        List<XApp> xApps;

        public AppsViewer()
        {
            InitializeComponent();
            xApps = new List<XApp>();
            AppList.ItemsSource = xApps;
            for(int i = 0; i < 9; i++)
            {
                XApp app = new XApp();
                xApps.Add(app);
            }
        }

        private void ScrollLeftButton_Click(object sender, RoutedEventArgs e)
        {
            //cant use because of data binding
            //AppsScrollView.ScrollToHorizontalOffset(AppsScrollView.HorizontalOffset + 4);

            int widthOfOneApp = (int)(xApps.First().ActualWidth + (2 * xApps.First().Margin.Left)); 

            AppsScrollView.ScrollToHorizontalOffset(AppsScrollView.HorizontalOffset - (1 *  widthOfOneApp));
        }

        private void ScrollRightButton_Click(object sender, RoutedEventArgs e)
        {
            int widthOfOneApp = (int)(xApps.First().ActualWidth + (2 * xApps.First().Margin.Left));

            AppsScrollView.ScrollToHorizontalOffset(AppsScrollView.HorizontalOffset + (1 * widthOfOneApp));
        }
    }
}
