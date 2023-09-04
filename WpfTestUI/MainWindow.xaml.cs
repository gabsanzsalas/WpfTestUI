using System;
using System.Collections.Generic;
using System.Drawing;
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

namespace WpfTestUI
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
        private void btnBlue_Click(object sender, RoutedEventArgs e)
        {
            UColors1.EStatus = StatusColors.EBlue;
            Brush blueBrush = new SolidColorBrush(Colors.Blue);
            UColors1.recBackBlue.Fill = blueBrush;
        }

        private void btnRed_Click(object sender, RoutedEventArgs e)
        {
            Brush redBrush = new SolidColorBrush(Colors.Red);
            UColors1.recBackBlue.Fill = redBrush;
            UColors1.EStatus = StatusColors.ERed;
        }

        private void BtnBlue2_Click(object sender, RoutedEventArgs e)
        {
            UColors2.EStatus = StatusColors.EBlue;
            Brush blueBrush = new SolidColorBrush(Colors.Blue);
            UColors2.recBackBlue.Fill = blueBrush;
        }

        private void BtnRed2_Click(object sender, RoutedEventArgs e)
        {
            Brush redBrush = new SolidColorBrush(Colors.Red);
            UColors2.recBackBlue.Fill = redBrush;
            UColors2.EStatus = StatusColors.ERed;
        }
    }
}
