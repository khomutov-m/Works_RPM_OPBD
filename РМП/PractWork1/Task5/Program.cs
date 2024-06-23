namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя папки");
            DirectoryInfo directoryParent = new(Console.ReadLine());
            if (directoryParent.Exists)
            {
                var files = directoryParent.GetFiles("*", SearchOption.AllDirectories);
                foreach (var file in files)
                {
                    DirectoryInfo directoryChild =
                        new(@$"{directoryParent.FullName}\{file.CreationTime.Year}\{file.CreationTime.Month}\{file.CreationTime.Day}");
                    if (!directoryChild.Exists)
                        directoryChild.Create();
                    file.MoveTo(Path.Combine(directoryChild.FullName, file.Name));
                }
            }
            else
                Console.WriteLine("Данной папки не существует");
        }
    }
}
