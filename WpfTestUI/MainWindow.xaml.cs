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
using static WpfTestUI.UIStatus;

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
        private void btnMeasuring_Click(object sender, RoutedEventArgs e)
        {
            ElipseControl.ElipseStatus = StatusColorsUI.EMisuring;
            RectangleControl.RectangleStatus = StatusColorsUI.EMisuring;
            BackgroundControl.BackgroundStatus = StatusColorsUI.EMisuring;
        }

        private void btnWorking_Click(object sender, RoutedEventArgs e)
        {
            ElipseControl.ElipseStatus = StatusColorsUI.EWorking;
            RectangleControl.RectangleStatus = StatusColorsUI.EWorking;
            BackgroundControl.BackgroundStatus = StatusColorsUI.EWorking;
        }

        private void btnIdle_Click(object sender, RoutedEventArgs e)
        {
            ElipseControl.ElipseStatus = StatusColorsUI.EIdle;
            RectangleControl.RectangleStatus = StatusColorsUI.EIdle;
            BackgroundControl.BackgroundStatus = StatusColorsUI.EIdle;
        }
    }
}
