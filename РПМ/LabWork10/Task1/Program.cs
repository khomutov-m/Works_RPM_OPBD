using Task1;

Abonent[] abonents = 
{ 
    new("Максимов Максим Максимович", 89009134458, 50),
    new("Егоров Егор Егорович", 89116755542, 37),
    new("Николаев Николай Николаевич",89102342254,500),
    new("Алексеев Алексей Алексеевич",89123214433,300),
    new()
};

foreach (var item in abonents)
{
    item.Print();
}

Array.Sort(abonents);
Console.WriteLine();
foreach (var item in abonents)
{
    item.Print();
}

Console.WriteLine();
Abonent abonent1 = new();
if (abonent1.Equals(abonents[2]))
    Console.WriteLine("Объекты равны");
else
    Console.WriteLine("Объекты неравны");

if (abonent1.Equals(abonents[0]))
    Console.WriteLine("Объекты равны");
else
    Console.WriteLine("Объекты неравны");

Console.WriteLine();
Abonent abonentClone1 = abonent1;
Abonent abonentClone2 = abonent1.Clone() is Abonent abonent ? abonent : new();

abonent1.TimeCall = 999;
abonentClone1.Print();
abonentClone2.Print();

Console.WriteLine();
Array.Sort(abonents, new DescendingComparerAbonent());
foreach (var item in abonents)
{
    item.Print();
}

Console.WriteLine();
Array.Sort(abonents, new StringComparerAbonent());
foreach (var item in abonents)
{
    item.Print();
}
