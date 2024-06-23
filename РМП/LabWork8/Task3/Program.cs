using Task3;

Figure square = new Square(4);
Console.WriteLine($"Площадь: {square.Area()}");
Console.WriteLine($"Периметр: {square.Perimeter()}");
square.Print();


ExtendedRandom extendedRandom = new();
int[] array = extendedRandom.ArrayRandom(8, 1, 500);

for (int i = 0; i < 8; i++)
{
    Console.WriteLine(array[i]);
}
