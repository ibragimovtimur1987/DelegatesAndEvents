namespace DelegatesAndEvents;

public class FileSearchEventArgs : EventArgs
{
    public string FileName { get; }
    
    public FileSearchEventArgs(string fileName)
    {
        FileName = fileName;
    }
}