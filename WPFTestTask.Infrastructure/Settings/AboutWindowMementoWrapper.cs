using WPFTestTask.Domain.Settings;
using WPFTestTask.Infrastructure.Common;

namespace WPFTestTask.Infrastructure.Settings;

internal class AboutWindowMementoWrapper : WindowMementoWrapper<AboutWindowMemento>, IAboutWindowMementoWrapper
{
    public AboutWindowMementoWrapper(IPathService pathService) 
        : base(pathService) 
    { 
    }
    protected override string MementoName => "AboutWindowMemento";
}
