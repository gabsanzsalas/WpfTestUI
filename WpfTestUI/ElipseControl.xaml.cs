using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    /// Logica di interazione per ElipseControl.xaml
    /// </summary>
    public partial class ElipseControl : UserControl
    {
        public static readonly DependencyProperty ElipseStatusProperty =
            DependencyProperty.Register("ElipseStatus", typeof(StatusColorsUI), typeof(ElipseControl) , new PropertyMetadata(StatusColorsUI.EIdle));

        public static readonly DependencyProperty ElipseFillProperty =
            DependencyProperty.Register("ElipseFill", typeof(Brush), typeof(ElipseControl));


        public StatusColorsUI ElipseStatus
        {
            get { return (StatusColorsUI)GetValue(ElipseStatusProperty); }
            set
            {
                SetValue(ElipseStatusProperty, value);
                switch (value)
                {
                    case StatusColorsUI.EMisuring:
                        this.SetValue(ElipseFillProperty, new SolidColorBrush(Colors.Green));
                        break;
                    case StatusColorsUI.EWorking:
                        this.SetValue(ElipseFillProperty, new SolidColorBrush(Colors.Red));
                        break;
                    case StatusColorsUI.EIdle:
                        this.SetValue(ElipseFillProperty, new SolidColorBrush(Colors.Gray));
                        break;
                    default:
                        this.SetValue(ElipseFillProperty, new SolidColorBrush(Colors.Black));
                        break;
                };
            }
        }
        public ElipseControl()
        {
            InitializeComponent();
        }
    }
}
