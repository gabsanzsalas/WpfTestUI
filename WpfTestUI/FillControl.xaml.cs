using System.Windows;
using System.Windows.Media;

namespace WpfTestUI
{
    /// <summary>
    /// Logica di interazione per FillControl.xaml
    /// </summary>
    public partial class FillControl : UCTestableStatus<StatusRectangle>, IUCTestableStatus<StatusRectangle>
    {
        public static readonly DependencyProperty RectangleFillProperty = DependencyProperty.Register("RectangleFill", typeof(Brush), typeof(FillControl));

        public override void SetStatus(StatusRectangle status)
        {
            switch (status)
            {
                case StatusRectangle.Open:
                    this.SetValue(RectangleFillProperty, new SolidColorBrush(Colors.Green));
                    break;
                case StatusRectangle.Close:
                    this.SetValue(RectangleFillProperty, new SolidColorBrush(Colors.Red));
                    break;
                case StatusRectangle.Idle:
                    this.SetValue(RectangleFillProperty, new SolidColorBrush(Colors.White));
                    break;
            };
        }

        public FillControl()
        {
            InitializeComponent();
        }
    }
    public enum StatusRectangle
    {
        Open,
        Close,
        Idle
    }
}
