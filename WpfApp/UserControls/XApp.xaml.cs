using MiscUtil;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace WpfApp.UserControls
{
    /// <summary>
    /// Interaction logic for XApp.xaml
    /// </summary>
    public partial class XApp : UserControl
    {
        public XApp()   
        {
            InitializeComponent();
            List<string> filePaths = Directory.GetFiles(Environment.CurrentDirectory + @"\..\..\Images", "*.png").ToList<string>();

            FileInfo randomFileInfo = new FileInfo(filePaths[StaticRandom.Next(filePaths.Count)]);

            ProductImage.Source = new BitmapImage(new Uri(randomFileInfo.FullName, UriKind.RelativeOrAbsolute));

            AppNameText.Text = (new CultureInfo("en-US", false).TextInfo).
                ToTitleCase(
                    randomFileInfo.FullName.Split('\\').Last().Split('-').Last().Split('.').First()
                );
        }

        private void ProductImage_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
