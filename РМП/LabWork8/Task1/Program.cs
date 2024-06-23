using Task1;

Abonent abonent1 = new();
Console.WriteLine(abonent1.ToString());
Console.WriteLine(abonent1);

Console.WriteLine();
Abonent abonent2 = new();
abonent2.TimeCall = 1;
if (abonent1.Equals(abonent2))
    Console.WriteLine("Объекты одинаковые");
else
    Console.WriteLine("Объекты разные");