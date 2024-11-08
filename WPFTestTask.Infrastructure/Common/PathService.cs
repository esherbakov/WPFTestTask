﻿using WPFTestTask.Domain.Settings;

namespace WPFTestTask.Infrastructure.Common;

internal class PathService: IPathService, IPathServiceInitializer
{
    private string _applicationFolder = string.Empty;
    private bool _initialized;

    public string ApplicationFolder
    {
        get
        {
            EnsureInitialized();
            return _applicationFolder;
        } 
        private set => _applicationFolder = value;
    }
    public void Initialize()
    {
        if (_initialized)
            throw new InvalidOperationException($"{nameof(IPathService)} is already initialized");

        _initialized = true;

        var localApplicationDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        const string company = "drowsy";
        const string applicationName = "testTask";

        ApplicationFolder = Path.Combine(localApplicationDataPath, company, applicationName);  
    }

    private void EnsureInitialized()
    {
        if (!_initialized)
            throw new InvalidOperationException($"{nameof(IPathService)} is not initialized");
    }
}