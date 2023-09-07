using System.Windows;
using System.Windows.Media;


namespace WpfTestUI
{
    /// <summary>
    /// Logica di interazione per ElipseControl.xaml
    /// </summary>
    public partial class ElipseControl : UCTestableStatus<StatusElipse>, IUCTestableStatus<StatusElipse>
    {
        public static readonly DependencyProperty ElipseFillProperty = DependencyProperty.Register("ElipseFill", typeof(Brush), typeof(ElipseControl));

        public override void SetStatus(StatusElipse status)
        {
            switch (status)
            {
                case StatusElipse.Yes:
                    this.SetValue(ElipseFillProperty, new SolidColorBrush(Colors.Green));
                    break;
                case StatusElipse.Not:
                    this.SetValue(ElipseFillProperty, new SolidColorBrush(Colors.Red));
                    break;
                case StatusElipse.Idle:
                    this.SetValue(ElipseFillProperty, new SolidColorBrush(Colors.White));
                    break;
            };
        }
        public ElipseControl()
        {
            InitializeComponent();
        }

}
    public enum StatusElipse
    {
        Yes,
        Not,
        Idle
    }
}
