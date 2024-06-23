int[] array = { 97, 45, 32, 65, 83, 23, 15 };
Array.Sort(array);
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Число {array[i]} Позиция {i + 1}");
}
int number = 15;
int position = -1;
int jump = (int)Math.Sqrt(array.Length - 1);
int allJump = jump;


while (allJump < array.Length)
{
    if (array[allJump] > number || allJump + jump > array.Length)
    {
        for (int i = allJump - jump; i < array.Length; i++)
        {
            if (number == array[i])
            {
                position = i + 1;
                break;
            }
        }
        break;
    }
    else
    {
        allJump = jump + allJump;
    }
}

Console.WriteLine($"Позиция {position}");