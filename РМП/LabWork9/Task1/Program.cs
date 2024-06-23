using Task1;

Abonent abonent = new();
Ellipse ellipse = new(2, 4);

abonent.Print();
Console.WriteLine();
ellipse.Print();
Console.WriteLine(ellipse.Name);
ellipse.PrintFull();

Console.WriteLine();
IPrinter printer = abonent;
printer.Print();
printer = ellipse;
printer.Print();

IPrinter[] printers =
{
    new Abonent("Денисов Денис Денисович", 79008331566, 1000),
    new Abonent("Антонов Антон Антонович", 79125607792, 15),
    new Ellipse(1, 3),
    new Ellipse(3, 5)
};

Console.WriteLine();
for (int i = 0; i < printers.Length; i++)
{
    if (printers[i] is IFigure tempEllipse)
        Console.WriteLine(tempEllipse.Name);
    printers[i].Print();
    Console.WriteLine();
}