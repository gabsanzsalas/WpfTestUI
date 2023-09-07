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
using static WpfTestUI.UIStatus;

namespace WpfTestUI
{
    /// <summary>
    /// Logica di interazione per FillControl.xaml
    /// </summary>
    public partial class FillControl : UserControl
    {

        public static readonly DependencyProperty RectangleStatusProperty =
            DependencyProperty.Register("RectangleStatus", typeof(StatusColorsUI), typeof(FillControl), new PropertyMetadata(StatusColorsUI.EIdle));

        public static readonly DependencyProperty RectangleFillProperty =
            DependencyProperty.Register("RectangleFill", typeof(Brush), typeof(FillControl));


        public StatusColorsUI RectangleStatus
        {
            get { return (StatusColorsUI)GetValue(RectangleStatusProperty); }
            set
            {
                SetValue(RectangleStatusProperty, value);
                switch (value)
                {
                    case StatusColorsUI.EMisuring:
                        this.SetValue(RectangleFillProperty, new SolidColorBrush(Colors.Green));
                        break;
                    case StatusColorsUI.EWorking:
                        this.SetValue(RectangleFillProperty, new SolidColorBrush(Colors.Purple));
                        break;
                    case StatusColorsUI.EIdle:
                        this.SetValue(RectangleFillProperty, new SolidColorBrush(Colors.Gray));
                        break;
                    default:
                        this.SetValue(RectangleFillProperty, new SolidColorBrush(Colors.Black));
                        break;
                };
            }
        }
        public FillControl()
        {
            InitializeComponent();
        }
    }
}
