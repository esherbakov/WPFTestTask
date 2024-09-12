using System.Windows;
using Autofac;
using WPFTestTask.Infrastructure.Settings;
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

        _container = containerBuilder.Build();
    }

    public void Dispose()
    {
        _container.Dispose();
    }

    public Window Run()
    {
        InitializeDependencies();

        var mainWindow = _container.Resolve<IMainWindow>();

        if (mainWindow is not Window window) throw new NotImplementedException();

        window.Show();

        return window;
    }

    private void InitializeDependencies()
    {
        _container.Resolve<IMainWindowMementoWrapperInitializer>().Initialize();
    }
}