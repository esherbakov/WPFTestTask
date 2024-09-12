using System.Windows;
using Autofac;
using WPFTestTask.Infrastructure.Settings;
using WPFTestTask.ViewModels.MainWindow;
using WPFTestTask.ViewModels.Windows;
using WPFTestTask.Views;
using WPFTestTask.Views.MainWindow;

namespace WPFTestTask.Bootstrapper;

public class Bootstrapper : IDisposable
{
    private readonly IContainer _container;

    public Bootstrapper()
    {
        var containerBuilder = new ContainerBuilder();

        containerBuilder.RegisterModule<RegistrationModule>();
        containerBuilder.RegisterModule<ViewModels.RegistrationModule>();
        containerBuilder.RegisterModule<Infrastructure.RegistrationModule>();
        containerBuilder.RegisterModule<Views.RegistrationModule>();

        _container = containerBuilder.Build();
    }

    public void Dispose()
    {
        _container.Dispose();
    }

    public Window Run()
    {
        InitializeDependencies();

        var mainWindowViewModel = _container.Resolve<IMainWindowViewModel>();
        var windowManager = _container.Resolve<IWindowManager>();

        var mainWindow = windowManager.Show((mainWindowViewModel));
        //var mainWindow = _container.Resolve<IMainWindow>();

        if (mainWindow is not Window window) 
            throw new NotImplementedException();

        return window;
    }

    private void InitializeDependencies()
    {
        _container.Resolve<IMainWindowMementoWrapperInitializer>().Initialize();
    }
}