using System.Windows.Input;
using WPFTestTask.Domain.Settings;
using WPFTestTask.ViewModels.Commands;
using WPFTestTask.ViewModels.Windows;

namespace WPFTestTask.ViewModels.MainWindow
{
    public class MainWindowViewModel : IMainWindowViewModel
    {
        private readonly IMainWindowMementoWrapper _mainWindowMementoWrapper;
        private readonly IWindowManager _windowManager;
        private Command _closeMainWindowCommand;

        public MainWindowViewModel(
            IMainWindowMementoWrapper mainWindowMementoWrapper,
            IWindowManager windowManager)
        {
            _mainWindowMementoWrapper = mainWindowMementoWrapper;
            _windowManager = windowManager;

            _closeMainWindowCommand = new Command(CloseMainWindow);
        }

        public double Left
        {
            get => _mainWindowMementoWrapper.Left;
            set => _mainWindowMementoWrapper.Left = value;
        }

        public double Top
        {
            get => _mainWindowMementoWrapper.Top;
            set => _mainWindowMementoWrapper.Top = value;
        }

        public double Width
        {
            get => _mainWindowMementoWrapper.Width;
            set => _mainWindowMementoWrapper.Width = value;
        }

        public double Height
        {
            get => _mainWindowMementoWrapper.Height;
            set => _mainWindowMementoWrapper.Height = value;
        }

        public bool IsMaximized
        {
            get => _mainWindowMementoWrapper.IsMaximized;
            set => _mainWindowMementoWrapper.IsMaximized = value;
        }

        public string Title => "Test Task";

        public ICommand CloseMainWindowCommand => _closeMainWindowCommand;

        private void CloseMainWindow()
        {
            _windowManager.Close(this);
        }
    }
}

