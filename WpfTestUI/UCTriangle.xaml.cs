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
using static WpfTestUI.UIStatus;

namespace WpfTestUI
{
    /// <summary>
    /// Interaction logic for UCTriangle.xaml
    /// </summary>
    public partial class UCTriangle : UCTestableStatus<StatusTriangle>, IUCTestableStatus<StatusTriangle>
    {

        public static readonly DependencyProperty TriangleFillProperty = DependencyProperty.Register("TriangleFill", typeof(Brush), typeof(UCTriangle));
        public UCTriangle()
        {
            InitializeComponent();
        }

        public override void SetStatus(StatusTriangle status)
        {
            switch (status)
            {
                case StatusTriangle.Online:
                    this.SetValue(TriangleFillProperty, new SolidColorBrush(Colors.Green));
                    break;
                case StatusTriangle.Offline:
                    this.SetValue(TriangleFillProperty, new SolidColorBrush(Colors.Red));
                    break;
            };
        }
    }

    public enum StatusTriangle
    {
        Online,
        Offline
    }
}
