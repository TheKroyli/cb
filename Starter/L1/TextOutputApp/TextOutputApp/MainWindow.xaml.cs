using System.Windows;

namespace TextOutputApp
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

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Text_Box1.Text = Text_Box2.Text; Text_Box1.Text = Text_Box2.Text;
        }
    }
}
