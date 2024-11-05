using System.Windows.Input;
using WPFTestTask.Domain.Settings;
using WPFTestTask.ViewModels.AboutWindow;
using WPFTestTask.ViewModels.Commands;
using WPFTestTask.ViewModels.Windows;
using WPFTestTask.Repository;
using WPFTestTask.Repository.TestData;

namespace WPFTestTask.ViewModels.MainWindow;

public class MainWindowViewModel : WindowViewModel<IMainWindowMementoWrapper>, IMainWindowViewModel
{
    private readonly IWindowManager _windowManager;
    private readonly IAboutWindowViewModel _aboutWindowViewModel;
    TestEntityRepository _repository = new TestEntityRepository();

    private readonly Command _closeMainWindowCommand;
    private readonly Command _openAboutWindowCommand;
    private readonly Command _createCommand;
    private readonly Command _readCommand;
    private readonly Command _updateCommand;
    private readonly Command _deleteCommand;


    public MainWindowViewModel(
        IMainWindowMementoWrapper mainWindowMementoWrapper,
        IWindowManager windowManager,
        IAboutWindowViewModel aboutWindowViewModel)
        : base(mainWindowMementoWrapper)
    {
        _windowManager = windowManager;
        _aboutWindowViewModel = aboutWindowViewModel;

        _closeMainWindowCommand = new Command(CloseMainWindow);
        _openAboutWindowCommand = new Command(OpenAboutWindow);
        _createCommand = new Command(Create);
        _readCommand = new Command(Read);
        _updateCommand = new Command(Update);
        _deleteCommand = new Command(Delete);
    }

    public string Title => "WPF Test Task";

    private void OpenAboutWindow()
    {
        _windowManager.Show(_aboutWindowViewModel);
    }

    public ICommand CloseMainWindowCommand => _closeMainWindowCommand;
    public ICommand OpenAboutWindowCommand => _openAboutWindowCommand;
    public ICommand CreateCommand => _createCommand;
    public ICommand ReadlCommand => _readCommand;
    public ICommand UpdatelCommand => _updateCommand;
    public ICommand DeleteCommand => _deleteCommand;

    private void CloseMainWindow()
    {
        _windowManager.Close(this);
    }

    private void Create()
    {
        TestEntity test = new TestEntity { Name = "Тест"};
        _repository.Create(test);
    }

    private void Read()
    {
        List<TestEntity> entities = _repository.GetAll();
    }

    private void Update()
    {
        TestEntity? test = _repository.GetAll().FirstOrDefault();
        if (test != null)
        {
            test.Name = "тест2";
            _repository.Update(test);
        }
    }

    private void Delete()
    {
        TestEntity? test = _repository.GetAll().FirstOrDefault();
        if (test != null)
        {
            _repository.DeleteById(test.Id);
        }
    }
}


