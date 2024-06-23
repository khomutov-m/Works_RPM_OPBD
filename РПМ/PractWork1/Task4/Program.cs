namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя папки");
            DirectoryInfo directory = new(Console.ReadLine());
            if (directory.Exists)
            {
                Console.WriteLine("Введите текст, содержащийся в имени файла");
                var searchText = Console.ReadLine();
                var files = directory.GetFiles("*", SearchOption.AllDirectories);
                foreach (var file in files)
                {
                    if (file.Name.Contains(searchText))
                        Console.WriteLine($"Имя файла: {file.Name}\nРазмер: {file.Length}");
                }
            }
            else
                Console.WriteLine("Данной папки не существует");
        }
    }
}
