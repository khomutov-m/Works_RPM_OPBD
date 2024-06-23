Dictionary<int, string> workers = new()
{
    { 1, "Иван Иванович Иванов" },
    { 2, "Иван Иванович Иванов" },
    { 3, "Иван Иванович Иванов" }
};

int itemsCount;
do
{
    Console.WriteLine("Введите количество новых элементов");
    itemsCount = Convert.ToInt32(Console.ReadLine());
} while (itemsCount < 0);

for (int i = 0; i < itemsCount; i++)
{
    Console.WriteLine("Введите табельный номер:");
    int key = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите ФИО: ");
    string value = Console.ReadLine();
    workers.TryAdd(key, value);
}

foreach (var worker in workers)
    Console.WriteLine($"Табельный номер: {worker.Key} \tФИО:{worker.Value}");
Console.WriteLine($"Всего человек: {workers.Count}");

Console.WriteLine("Введите ключ искомого элемента");
int keyFind = Convert.ToInt32(Console.ReadLine());
if (workers.ContainsKey(keyFind))
    Console.WriteLine($"{workers[keyFind]} - {keyFind}");
else
    Console.WriteLine("Его нет");

Console.WriteLine("Введите значение:");
string valueFind = Console.ReadLine();
int count = 0;
foreach (var worker in workers)
{
    if (worker.Value == valueFind)
        count++;
}
Console.WriteLine($"Количество совпадений: {count}");
Console.WriteLine("Введите ключ для удаления");
int keyToDelete = Convert.ToInt32(Console.ReadLine());
workers.Remove(keyToDelete);
foreach (var worker in workers)
    Console.WriteLine($"Ключ: {worker.Key} \tЗначение:{worker.Value}");

