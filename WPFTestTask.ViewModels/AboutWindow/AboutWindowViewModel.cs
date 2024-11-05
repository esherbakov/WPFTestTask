using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFTestTask.Domain.Settings;
using WPFTestTask.ViewModels.MainWindow;

namespace WPFTestTask.ViewModels.AboutWindow
{
    public class AboutWindowViewModel : WindowViewModel<IAboutWindowMementoWrapper>, IAboutWindowViewModel
    {
        public AboutWindowViewModel(IAboutWindowMementoWrapper windowMementoWrapper)
            : base(windowMementoWrapper)
        {
        }
    }
}
