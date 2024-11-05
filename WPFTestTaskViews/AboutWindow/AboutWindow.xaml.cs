using System.Windows;
using WPFTestTask.ViewModels.Windows;
using WPFTestTask.ViewModels.AboutWindow;

namespace WPFTestTask.Views.AboutWindow
{
    public partial class AboutWindow : IAboutWindow
    {
        public AboutWindow(IAboutWindowViewModel aboutWindowViewModel)
        {
            InitializeComponent();

            DataContext = aboutWindowViewModel;
        }
    }

    public interface IAboutWindow : IWindow
    {
    }
}
