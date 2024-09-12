using Autofac;
using WPFTestTask.Bootstrapper.Factories;
using WPFTestTask.Views.Factories;

namespace WPFTestTask.Bootstrapper
{
    public class RegistrationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<WindowFactory>().As<IWindowFactory>().SingleInstance();
        }
    }
}
