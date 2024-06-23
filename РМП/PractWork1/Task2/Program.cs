namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя файла");
            var file = Console.ReadLine();
            if (File.Exists(file))
                Console.WriteLine($"Файл {file} открыт на дозапись");
            else
                Console.WriteLine($"Файл {file} создан");
            Console.WriteLine("Для завершения работы напишите end.");
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "end")
                    break;
                File.AppendAllText(file, $"{line}\n");
            }
        }
    }
}
