using System;
using System.Collections.Generic;
using System.Configuration;
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
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
       

        public static readonly DependencyProperty StatusProperty =
    DependencyProperty.Register("EStatus", typeof(StatusColors), typeof(UserControl1));


        public StatusColors EStatus
        {
            get { return (StatusColors)this.GetValue(StatusProperty); }
            set { this.SetValue(StatusProperty, value); }
        }


        public UserControl1()
        {
            InitializeComponent();
        }
    }
    public enum StatusColors
    {
        EBlue,
        ERed
    }
}
