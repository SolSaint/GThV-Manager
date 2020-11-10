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

namespace GThV_Manager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SolidColorBrush Off = new SolidColorBrush(Color.FromRgb(0, 0, 0));
        SolidColorBrush On = new SolidColorBrush(Color.FromRgb(240, 222, 45));

        public MainWindow()
        {
            InitializeComponent();

            this.MinHeight = 600;
            this.MinWidth = 1024;

            Uri iconUri = new Uri("pack://application:,,,/Image/icons8_skull_crossbones.ico");
            this.Icon = BitmapFrame.Create(iconUri);
        }

        private void Bu_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if ( Bu.Toggled1 == true)
            {
                Light.Fill = On;
            }
            else
            {
                Light.Fill = Off;
            }
        }
    }
}
