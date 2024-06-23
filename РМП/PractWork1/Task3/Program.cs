namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя файла");
            var file = Console.ReadLine();
            if (File.Exists(file))
            {
                Console.WriteLine("Введите искомый текст");
                var searchText = Console.ReadLine();
                var lines = File.ReadAllLines(file);
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].Contains(searchText))
                        Console.WriteLine($"{i + 1}: Строка {lines[i]}");
                }
            }
            else
                Console.WriteLine("Файл не существует");
        }
    }
}
