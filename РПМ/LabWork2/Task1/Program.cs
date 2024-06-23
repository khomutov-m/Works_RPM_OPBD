int[] array = { 97, 45, 32, 65, 83, 23, 15 };
int number = 65;
int position = -1;

for (int i = 0; i < array.Length; i++)
{
    if (number == array[i])
    {
        position = i + 1;
        break;
    }
}

Console.WriteLine($"Позиция {position}");