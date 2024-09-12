﻿
using System.Windows;

namespace WPFTestTask.Bootstrapper
{
    public class Bootstrapper : IDisposable
    {
        public Window Run()
        {
            var mainWindow = new MainWindow();

            mainWindow.Show();

            return mainWindow;
        }
        public void Dispose()
        {

        }
    }
}
