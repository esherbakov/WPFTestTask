﻿using Autofac;
using WPFTestTask.ViewModels.Windows;
using WPFTestTask.Views.MainWindow;
using WPFTestTask.Views.Windows;

namespace WPFTestTask.Views
{
    public class RegistrationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterType<MainWindow.MainWindow>().As<IMainWindow>().InstancePerDependency();
            builder.RegisterType<WindowManager>().As<IWindowManager>().SingleInstance();
        }
    }
}
