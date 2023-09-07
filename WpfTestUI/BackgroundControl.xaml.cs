using System.Windows;
using System.Windows.Media;

namespace WpfTestUI
{
    /// <summary>
    /// Logica di interazione per BackgroundControl.xaml
    /// </summary>
    public partial class BackgroundControl : UCTestableStatus<StatusBG>, IUCTestableStatus<StatusBG>
    {
        public static readonly DependencyProperty BGFillProperty = DependencyProperty.Register("BGFill", typeof(Brush), typeof(BackgroundControl));

        public override void SetStatus(StatusBG status)
        {
            switch (status)
            {
                case StatusBG.Fill:
                    this.SetValue(BGFillProperty, new SolidColorBrush(Colors.Green));
                    break;
                case StatusBG.NotFill:
                    this.SetValue(BGFillProperty, new SolidColorBrush(Colors.Red));
                    break;
                case StatusBG.Idle:
                    this.SetValue(BGFillProperty, new SolidColorBrush(Colors.White));
                    break;
            };
        }
        public BackgroundControl()
        {
            InitializeComponent();
        }
    }
    public enum StatusBG
    {
        Fill,
        NotFill,
        Idle
    }
}
