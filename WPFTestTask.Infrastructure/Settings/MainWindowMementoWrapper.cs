using WPFTestTask.Domain.Settings;
using WPFTestTask.Infrastructure.Common;

namespace WPFTestTask.Infrastructure.Settings;

internal class MainWindowMementoWrapper : WindowMementoWrapper<MainWindowMemento>, IMainWindowMementoWrapper
{
    public MainWindowMementoWrapper(IPathService pathService)
        : base(pathService)
    {
    }
    protected override string MementoName => "MainWindowMemento";
}
