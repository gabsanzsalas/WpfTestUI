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

namespace WpfTestUI
{
    /// <summary>
    /// Logica di interazione per UIStatus.xaml
    /// </summary>
    public partial class UIStatus : UserControl
    {

        public static readonly DependencyProperty UIStatusProperty =
            DependencyProperty.Register("UIStatusLabel", typeof(StatusColorsUI), typeof(UIStatus));

        public StatusColorsUI UIStatusLabel
        {
            get { return (StatusColorsUI)this.GetValue(UIStatusProperty); }
            set { this.SetValue(UIStatusProperty, value); }
        }

        public UIStatus()
        {
            InitializeComponent();
        }

        public enum StatusColorsUI
        {
            EIdle,
            EWorking,
            EMisuring
        }
    }
}
