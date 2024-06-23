int[] array = { 97, 45, 32, 65, 83, 23, 15 };
Array.Sort(array);
int number = 15;
int position = -1;
int right = array.Length - 1;
int left = 0;

do
{
    int middle = left + (right - left) / 2;
    if (number == array[middle])
    {
        position = middle + 1;
        break;
    }
    else if (number > array[middle])
    {
        left = middle + 1;
    }
    else
    {
        right = middle - 1;
    }
} while (left <= right) ;

Console.WriteLine($"Позиция {position}");


