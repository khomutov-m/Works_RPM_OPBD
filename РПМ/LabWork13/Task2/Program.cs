using System.Text;

Console.WriteLine("Введите строку:");
string text = Console.ReadLine();

string strModified = text.Trim();
while (strModified.Contains("  "))
{
    strModified = strModified.Replace("  ", " ");
}
Console.WriteLine($"Измененная строка: {strModified}");

Console.WriteLine("Введите номер регистра (0-верхний, 1-нижний, 2-инвертированный):");
int register = Convert.ToInt16(Console.ReadLine());
switch (register)
{
    case 0:
        text = text.ToUpper();
        break;
    case 1:
        text = text.ToLower();
        break;
    case 2:
        StringBuilder builder = new StringBuilder(text);
        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsLower(builder[i]))
                builder[i] = char.ToUpper(builder[i]);
            else
                builder[i] = char.ToLower(builder[i]);
        }
        text = builder.ToString();
        break;
    default:
        Console.WriteLine("Некорректные данные");
        break;
}

Console.WriteLine(text);