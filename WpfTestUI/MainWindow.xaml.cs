using System.Windows;

namespace WpfTestUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnMeasuring_Click(object sender, RoutedEventArgs e)
        {
            ElipseControl.UIStatusLabel = StatusElipse.Yes;
            BackgroundControl.UIStatusLabel = StatusBG.Fill;
            TriangleControl.UIStatusLabel = StatusTriangle.Online;
            RectangleControl.UIStatusLabel = StatusRectangle.Open;
        }

        private void btnWorking_Click(object sender, RoutedEventArgs e)
        {
            RectangleControl.UIStatusLabel = StatusRectangle.Close;
            BackgroundControl.UIStatusLabel = StatusBG.NotFill;
            TriangleControl.UIStatusLabel = StatusTriangle.Offline;
            ElipseControl.UIStatusLabel = StatusElipse.Not;
        }

        private void btnIdle_Click(object sender, RoutedEventArgs e)
        {
            RectangleControl.UIStatusLabel = StatusRectangle.Idle;
            BackgroundControl.UIStatusLabel = StatusBG.Idle;
            TriangleControl.UIStatusLabel = StatusTriangle.Idle;
            ElipseControl.UIStatusLabel = StatusElipse.Idle;


        }

    }
}
