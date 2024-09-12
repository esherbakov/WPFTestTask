using WPFTestTask.ViewModels.MainWindow;

namespace WPFTestTask.Views.MainWindow
{
    public partial class MainWindow : IMainWindow
    {
        public MainWindow(IMainWindowViewModel mainWindowViewModel)
        {
            InitializeComponent();

            DataContext = mainWindowViewModel;
        }
    }
}