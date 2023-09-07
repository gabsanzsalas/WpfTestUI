using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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
    /// Interaction logic for UIStatusLabel.xaml
    /// </summary>
    public partial class UIStatusLabel : UserControl
    {
        public UIStatusLabel()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty UIStatusStringProperty =
            DependencyProperty.Register("UIStatusString", typeof(string), typeof(UIStatusLabel));


        public string? UIStatusString
        {
            get { return this.GetValue(UIStatusStringProperty).ToString(); }
            set{   this.SetValue(UIStatusStringProperty, value);}
        }
    }
}
