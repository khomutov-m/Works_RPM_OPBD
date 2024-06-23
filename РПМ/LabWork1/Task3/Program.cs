
int[] numbers = { 7, 0, -4, 3, 1, -2, 5 };

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"{numbers[i]} \t");
}
Console.WriteLine();
Console.WriteLine();

for (int i = 1; i < numbers.Length; i++)
{
    for (int j = 0; j < i; j++)
    {
        if (numbers[j] > numbers[i])
        {
            (numbers[j], numbers[i]) = (numbers[i], numbers[j]);
        }
    }

    for (int j = 0; j < numbers.Length; j++)
    {
        Console.Write($"{numbers[j]} \t");
    }
    Console.WriteLine();
    Console.WriteLine();
}