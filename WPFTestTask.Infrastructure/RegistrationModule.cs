using Autofac;
using WPFTestTask.Domain.Settings;
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
                .As<IMainWindowMementoWrapperInitializer>()
                .SingleInstance();
        }
    }
}
