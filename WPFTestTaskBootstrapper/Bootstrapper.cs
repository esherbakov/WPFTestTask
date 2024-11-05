using System.Windows;
using Autofac;
using WPFTestTask.Infrastructure.Common;
using WPFTestTask.Infrastructure.Settings;
using WPFTestTask.ViewModels.MainWindow;
using WPFTestTask.ViewModels.Windows;

namespace WPFTestTask.Bootstrapper;

public class Bootstrapper : IDisposable
{
    private readonly IContainer _container;

    public Bootstrapper()
    {
        var containerBuilder = new ContainerBuilder();

        containerBuilder.RegisterModule<RegistrationModule>();
        containerBuilder.RegisterModule<Views.RegistrationModule>();
        containerBuilder.RegisterModule<ViewModels.RegistrationModule>();
        containerBuilder.RegisterModule<Infrastructure.RegistrationModule>();

        _container = containerBuilder.Build();
    }

    public Window Run()
    {
        InitializeDependencies();

        var mainWindowViewModel = _container.Resolve<IMainWindowViewModel>();
        var windowManager = _container.Resolve<IWindowManager>();

        var mainWindow = windowManager.Show(mainWindowViewModel);

        if (mainWindow is not Window window)
            throw new NotImplementedException();

        return window;
    }

    private void InitializeDependencies()
    {
        _container.Resolve<IPathServiceInitializer>().Initialize();
        
        var windowMementoWrapperInitializers = _container.Resolve<IEnumerable<IWindowMementoWrapperInitializer>>();

        foreach (var windowMementoWrapperInitializer in windowMementoWrapperInitializers)
            windowMementoWrapperInitializer.Initialize();

        
    }

    public void Dispose()
    {
        _container.Dispose();
    }
}