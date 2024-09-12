using WPFTestTask.ViewModels.Windows;

namespace WPFTestTask.Views.Factories
{
    public interface IWindowFactory
    {
        IWindow Create<TWindowViewModel>(TWindowViewModel viewModel)
            where TWindowViewModel : IWindowViewModel;
    }
}
