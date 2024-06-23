Console.WriteLine("Введите строку:");
string text = Console.ReadLine();

string[] separator = { " ", ".", "," };
string[] arrayStrings = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
for (int i = 0; i < arrayStrings.Length; i++)
{
    Console.WriteLine(arrayStrings[i]);
}