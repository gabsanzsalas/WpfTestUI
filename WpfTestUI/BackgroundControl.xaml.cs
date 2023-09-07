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
    /// Logica di interazione per BackgroundControl.xaml
    /// </summary>
    public partial class BackgroundControl : UserControl
    {

        public static readonly DependencyProperty BackgroundStatusProperty =
           DependencyProperty.Register("BackgroundStatus", typeof(StatusColorsUI), typeof(BackgroundControl), new PropertyMetadata(StatusColorsUI.EIdle));

        public static readonly DependencyProperty BackgroundFillProperty =
            DependencyProperty.Register("BackgroundFill", typeof(Brush), typeof(BackgroundControl));


        public StatusColorsUI BackgroundStatus
        {
            get { return (StatusColorsUI)GetValue(BackgroundStatusProperty); }
            set
            {
                SetValue(BackgroundStatusProperty, value);
                switch (value)
                {
                    case StatusColorsUI.EMisuring:
                        this.SetValue(BackgroundFillProperty, new SolidColorBrush(Colors.Green));
                        break;
                    case StatusColorsUI.EWorking:
                        this.SetValue(BackgroundFillProperty, new SolidColorBrush(Colors.Red));
                        break;
                    case StatusColorsUI.EIdle:
                        this.SetValue(BackgroundFillProperty, new SolidColorBrush(Colors.PowderBlue));
                        break;
                    default:
                        this.SetValue(BackgroundFillProperty, new SolidColorBrush(Colors.Black));
                        break;
                };
            }
        }
        public BackgroundControl()
        {
            InitializeComponent();
        }
    }
}
