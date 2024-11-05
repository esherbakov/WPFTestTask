using Autofac;
using WPFTestTask.Domain.Settings;
using WPFTestTask.Infrastructure.Common;
using WPFTestTask.Infrastructure.Settings;

namespace WPFTestTask.Infrastructure
{
    public class RegistrationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<MainWindowMementoWrapper>()
                .As<IMainWindowMementoWrapper>()
                .As<IWindowMementoWrapperInitializer>()
                .SingleInstance();

            builder.RegisterType<PathService>()
                .As<IPathService>()
                .As<IPathServiceInitializer>()
                .SingleInstance();

            builder.RegisterType<AboutWindowMementoWrapper>()
                .As<IAboutWindowMementoWrapper>()
                .As<IWindowMementoWrapperInitializer>()
                .SingleInstance();
        }
    }
}
