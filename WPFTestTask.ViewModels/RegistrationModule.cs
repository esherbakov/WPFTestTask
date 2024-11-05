using Autofac;
using WPFTestTask.ViewModels.AboutWindow;
using WPFTestTask.ViewModels.MainWindow;

namespace WPFTestTask.ViewModels
{
    public class RegistrationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<MainWindowViewModel>().As<IMainWindowViewModel>().InstancePerDependency();
            builder.RegisterType<AboutWindowViewModel>().As<IAboutWindowViewModel>().InstancePerDependency();
        }
    }
}
