using Task1;

Abonent abonent = new();
abonent.Print();
abonent++;
abonent.Print();

Console.WriteLine();
Abonent abonent1 = new("Антонов Антон Антонович", 89009548866, 50);
Abonent abonent2 = new();
Abonent abonent3 = abonent1 + abonent2;
abonent3.Print();

Console.WriteLine();
Abonent compareAbonent1 = new();
Abonent compareAbonent2 = new();
Console.WriteLine(compareAbonent1 == compareAbonent2);
Console.WriteLine(abonent1 != abonent2);

Console.WriteLine();
Abonent abonentNegative = new("Иван Иванович Иванов", 89009157777, 40);
if (abonentNegative)
    Console.WriteLine("+");
else
    Console.WriteLine("-");