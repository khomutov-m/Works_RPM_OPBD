List<string> fish = new() { "Килька", "Палтус", "Горбуша" };

int itemsCount;
do
{
    Console.WriteLine("Введите количество новых элементов");
    itemsCount = Convert.ToInt32(Console.ReadLine());
} while (itemsCount < 0);

for (int i = 0; i < itemsCount; i++)
{
    fish.Add(Console.ReadLine());
}

for (int i = 0; i < fish.Count; i++)
{
    Console.WriteLine($"{i + 1} элемент - {fish[i]}");
}
Console.WriteLine($"Количесвто элементов в списке: {fish.Count}");

Console.WriteLine();
string deleteItem = fish[fish.Count - 1];
fish.Remove(deleteItem);
fish.Insert(0, deleteItem);
foreach (var oneFish in fish)
{
    Console.WriteLine(oneFish);
}
