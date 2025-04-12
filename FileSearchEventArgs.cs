namespace DelegatesAndEvents;

public class FileSearchEventArgs : EventArgs, ICancelable
{
    public string FileName { get; }
    public bool Cancel { get; set; } // Свойство для отмены поиска

    public FileSearchEventArgs(string fileName)
    {
        FileName = fileName;
        Cancel = false; // По умолчанию не отменен
    }
}