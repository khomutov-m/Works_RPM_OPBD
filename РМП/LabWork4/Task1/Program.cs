int N, M;
Console.WriteLine("Введите число строк и столбцов");
N = Convert.ToInt32(Console.ReadLine());
M = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[N, M];
Random rnd = new Random();
int countBarrier = rnd.Next(3) + 2;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = -1;
    }
}

for (int i = 0; i < countBarrier; i++)
{
    int xBarrier = rnd.Next(N - 1);
    int yBarrier = rnd.Next(M - 1);
    array[xBarrier, yBarrier] = -2;
}

int xbeg;
int ybeg;
do
{
    Console.WriteLine("Введите x и y");
    xbeg = Convert.ToInt32(Console.ReadLine());
    ybeg = Convert.ToInt32(Console.ReadLine());
} while (!(xbeg > 0) || !(xbeg <= N) || !(ybeg > 0) || !(ybeg < M));
array[xbeg - 1, ybeg - 1] = 0;

int xfin = rnd.Next(array.GetLength(0));
int yfin = rnd.Next(array.GetLength(1));
if (array[xfin, yfin] == 0)
{
    xfin++;
}
array[xfin, yfin] = 99;


for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int distance = Math.Abs(i - xfin) + Math.Abs(j - yfin);
        Console.Write($"{array[i, j]}({distance}) \t");
    }
    Console.WriteLine();
}

int d = 0;
bool nobarrier;
do
{
    nobarrier = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == d)
            {
                if (i + 1 < N && array[i + 1, j] != -2)
                {
                    array[i + 1, j] = d + 1;
                    nobarrier = true;
                }
                if (i != 0 && array[i - 1, j] != -2)
                {
                    array[i - 1, j] = d + 1;
                    nobarrier = true;
                }
                if (j != 0 && array[i, j - 1] != -2)
                {
                    array[i, j - 1] = d + 1;
                    nobarrier = true;
                }
                if (j + 1 < M && array[i, j + 1] != -2)
                {
                    array[i, j + 1] = d + 1;
                    nobarrier = true;
                }
            }
        }
    }
    d++;
} while (array[xfin, yfin] != d && nobarrier);

if (nobarrier)
    Console.WriteLine($"Кратчайший путь: {d}");
else
    Console.WriteLine("Путей нет");

