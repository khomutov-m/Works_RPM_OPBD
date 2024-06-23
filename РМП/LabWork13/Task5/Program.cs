string[] arrayStrings = { "hello", "world", "today" };
Console.WriteLine("Введите текст:");
string text = Console.ReadLine();
if (String.Join("", arrayStrings).Contains(text))
{
    foreach (string str in arrayStrings)
        if (str.Contains(text))
            Console.WriteLine(str);
}
else
    Console.WriteLine("Текст не найден");