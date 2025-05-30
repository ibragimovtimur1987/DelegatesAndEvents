﻿namespace DelegatesAndEvents;

public class FileSearcher
{
    public event EventHandler<FileSearchEventArgs> FileFound;

    public void Search(string directory)
    {
        if (!Directory.Exists(directory))
            throw new DirectoryNotFoundException($"The directory {directory} does not exist.");

        foreach (var file in Directory.GetFiles(directory))
        {
            var args = new FileSearchEventArgs(Path.GetFileName(file));
            OnFileFound(args);
            // Проверяем, должен ли быть остановлен поиск
            if (args is ICancelable cancelableArgs && cancelableArgs.Cancel)
                break;
        }
    }

    protected virtual void OnFileFound(FileSearchEventArgs e)
    {
        FileFound?.Invoke(this, e);
    }
}