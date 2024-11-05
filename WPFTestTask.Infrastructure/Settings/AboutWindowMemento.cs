using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTestTask.Infrastructure.Settings
{
    internal class AboutWindowMemento : WindowMemento
    {
        public AboutWindowMemento()
        {
            Left = 100;
            Top = 100;
            Width = 600;
            Height = 400;
            IsMaximized = true;
        }
    }
}
