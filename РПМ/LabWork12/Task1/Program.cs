using Task1;

Abonent abonentCorrect = new("Антонов Святозар Николаевич", 89009168834, 2000);
Abonent abonentUncorrect = new("  ", 89998887766, -100);
abonentCorrect.Print();
Console.WriteLine();
abonentUncorrect.Print();

Abonent[] abonents =
{
    new(),
    new("Петров Григорий Генадьевич", 89997776655, 55),
    abonentCorrect
};
abonents[1].rate = Rate.Unlimited;
Console.WriteLine();
Console.WriteLine("Найдены следующие абоненты:");
for (int i = 0; i < abonents.Length; i++)
{
    if (abonents[i].rate == Rate.Unlimited)
        abonents[i].Print();
}

Console.WriteLine();
Console.WriteLine();
Student studentEqual1 = new("Иванов Иван Иванович", "Ландшафтный дизайнер", 3);
Student studentEqual2 = new("Иванов Иван Иванович", "Ландшафтный дизайнер", 3);

Student studentDifference1 = new("Петров Григорий Генадьевич", "Связист", 2);
Student studentDifference2 = new("Антонов Святозар Николаевич", "Связист", 2);

Console.WriteLine(studentEqual1);
Console.WriteLine(studentEqual2);
Console.WriteLine(studentDifference1);
Console.WriteLine(studentDifference2);

Console.WriteLine();
Console.WriteLine(studentEqual1.Equals(studentEqual2));
Console.WriteLine(studentDifference1.Equals(studentDifference2));