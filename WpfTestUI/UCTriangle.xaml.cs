using System.Windows;
using System.Windows.Media;


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
                case StatusTriangle.Idle:
                    this.SetValue(TriangleFillProperty, new SolidColorBrush(Colors.White));
                    break;
            };
        }
    }

    public enum StatusTriangle
    {
        Online,
        Offline,
        Idle
    }
}
