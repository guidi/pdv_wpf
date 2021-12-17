using System.Windows;

namespace Guidis.PDV.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var form = new LoginWindow();
            form.Show();

            this.Close();
        }
    }
}
