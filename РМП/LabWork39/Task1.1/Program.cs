namespace Task1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string directoryPath = Environment.CurrentDirectory; 

            var namesAndDates = Directory.EnumerateFileSystemEntries(directoryPath, "*", SearchOption.AllDirectories)
                .Select(file => new { Name = file, Created = File.GetCreationTime(file) })
                .Union(Directory.EnumerateDirectories(directoryPath, "*", SearchOption.AllDirectories)
                .Select(directory => new { Name = directory, Created = Directory.GetCreationTime(directory) }));
            foreach (var item in namesAndDates)
            {
                Console.WriteLine($"Имя: {item.Name}, Дата создания: {item.Created}");
            }

            var fileStats = Directory.EnumerateFiles(directoryPath, "*", SearchOption.AllDirectories)
                .GroupBy(file => Path.GetExtension(file))
                .Select(group => new { Extension = group.Key, TotalSize = group.Sum(file => new FileInfo(file).Length), FileCount = group.Count() });
            foreach (var stat in fileStats)
            {
                Console.WriteLine($"Расширение: {stat.Extension}, Общий размер: {stat.TotalSize}, Количество файлов: {stat.FileCount}");
            }

            var filesByMonth = Directory.EnumerateFiles(directoryPath, "*", SearchOption.AllDirectories)
                .GroupBy(file => new { File.GetCreationTime(file).Year, File.GetCreationTime(file).Month })
                .Select(group => new { group.Key.Year, group.Key.Month, FileCount = group.Count() });
            foreach (var monthStat in filesByMonth)
            {
                Console.WriteLine($"Год: {monthStat.Year}, Месяц: {monthStat.Month}, Количество файлов: {monthStat.FileCount}");
            }

            var filesInTodayFolders = Directory.EnumerateDirectories(directoryPath, "*", SearchOption.AllDirectories)
                .Where(date => Directory.GetCreationTime(date).Date == DateTime.Now.Date)
                .SelectMany(directory => Directory.EnumerateFiles(directory, "*", SearchOption.TopDirectoryOnly))
                .Select(file => new { Name = file, Folder = Path.GetDirectoryName(file) });
            foreach (var file in filesInTodayFolders)
            {
                Console.WriteLine($"Файл: {file.Name}, Папка: {file.Folder}");
            }

            var foldersWithFileCount = Directory.EnumerateDirectories(directoryPath, "*", SearchOption.AllDirectories)
                .GroupJoin(Directory.EnumerateFiles(directoryPath, "*", SearchOption.AllDirectories),
                    directory => directory,
                    Path.GetDirectoryName,
                    (directory, files) => new { FolderName = directory, FileCount = files.Count() });
            foreach (var folderStat in foldersWithFileCount)
            {
                Console.WriteLine($"Папка: {folderStat.FolderName}, Количество файлов: {folderStat.FileCount}");
            }
            Console.ReadKey();
        }
    }
}
