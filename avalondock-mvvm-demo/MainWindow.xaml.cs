using System.Windows;

namespace avalondock_mvvm_demo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainVm();
        }
    }
}
