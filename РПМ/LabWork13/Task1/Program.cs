Console.WriteLine("Введите строку:");
string text = Console.ReadLine();
Console.WriteLine($"Количество символов в строке - {text.Length}");
Console.WriteLine($"Количество символов в строке без учета пробелов - {text.Replace(" ", "").Length}");

int lettersCount = 0;
for (int i = 0; i < text.Length; i++)
{
    if (Char.IsLetter(text[i]))
        lettersCount++;
}

Console.WriteLine($"Количество букв в строке - {lettersCount}");

Console.WriteLine("Введите искомый символ:");
char desiredSymbol = Convert.ToChar(Console.ReadLine());
if (text.Contains(desiredSymbol))
{
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == desiredSymbol)
            Console.WriteLine($"Позиция {i + 1}");
    }
}
else
    Console.WriteLine("Такого символа нет.");
