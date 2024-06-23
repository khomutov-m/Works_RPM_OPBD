Console.WriteLine("Введите имя файла");
var file = Console.ReadLine();
if (File.Exists(file))
    Console.WriteLine(File.ReadAllText(file));
else
    Console.WriteLine("Файл не существует");
