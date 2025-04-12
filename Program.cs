using DelegatesAndEvents;
 // Пример использования функции расширения
 var numbers = new List<TestData>
 {
     new TestData { Value = 5 },
     new TestData { Value = 10 },
     new TestData { Value = 3 }
 };

 var maxElement = numbers.GetMax(x => x.Value);
 Console.WriteLine($"Максимальное значение: {maxElement?.Value}");

 // Пример использования FileSearcher
 var fileSearcher = new FileSearcher();
 fileSearcher.FileFound += FileSearcher_FileFound;

 // Укажите актуальный путь к каталогу
 string directoryPath = @"D:\tests\pdf";
 fileSearcher.Search(directoryPath);
 
 static void FileSearcher_FileFound(object sender, FileSearchEventArgs e)
 {
     Console.WriteLine($"Найден файл: {e.FileName}");
    
     // Условие для отмены поиска (например, по имени файла)
     if (e.FileName == "1944.pdf") // Например, если найден файл с именем "example.txt", поиск будет остановлен
     {
         e.Cancel = true; // Устанавливаем флаг отмены
     }
 }