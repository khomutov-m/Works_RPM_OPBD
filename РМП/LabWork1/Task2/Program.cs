
int[] numbers = { 7, 0, -4, 3, 1, -2, 5 };

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"{numbers[i]} \t");
}
Console.WriteLine();
Console.WriteLine();

for (int i = numbers.Length - 1; i > 0; i--)
{
    for (int j = numbers.Length - 1; j > 0; j--)
    {
        if (numbers[j] < numbers[j - 1])
        {
            (numbers[j], numbers[j - 1]) = (numbers[j - 1], numbers[j]);
        }
    }

    for (int j = 0; j < numbers.Length; j++)
    {
        Console.Write($"{numbers[j]} \t");
    }
    Console.WriteLine();
    Console.WriteLine();
}