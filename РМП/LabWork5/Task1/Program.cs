using Task1;

int searchTime;
long searchNumber;
Abonent abonent = new("Александров Александр  Александрович", 8954886450, -1);
abonent.Print();

Abonent[] abonents =
{
    new(),
    new("Андреев Андрей Андреевич", 89050678899, 150),
    new("Васильев Иван Иванович", 89030528877, 200),
    new("Носов Сергей Александрович", 89050677653, 500)
};

Console.WriteLine("Введите номер:");
searchNumber = Convert.ToInt64(Console.ReadLine());
for (int i = 0; i < abonents.Length; i++)
{
    if (abonents[i].PhoneNumber == searchNumber)
        abonents[i].Print();
}

Console.WriteLine("Введите время:");
searchTime = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < abonents.Length; i++)
{
    if (abonents[i].TimeCall > searchTime)
        abonents[i].Print();
}
