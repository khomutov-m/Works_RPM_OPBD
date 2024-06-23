namespace Task1._0
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            await Task.Run(() => ShowPower(2, -2));
            await Task.Run(() => ShowPower(0, 0));
            await Task.Run(() => ShowPower(3, 5));
            Console.WriteLine();
            await Task.WhenAll(
                Task.Run(() => ShowPower(2, -2)),
                Task.Run(() => ShowPower(0, 0)),
                Task.Run(() => ShowPower(3, 5))
                );
            Console.WriteLine();
            var results = await Task.WhenAll(
                Task.Run(() => GetPower(2, -2)),
                Task.Run(() => GetPower(0, 0)),
                Task.Run(() => GetPower(3, 5))
                );
            foreach (var result in results)
                Console.WriteLine(result);
            Console.WriteLine();
            results = await Task.WhenAll(
                Task.Run(() => DoOperation(2, 3, 4, 5, 6, 7, 8, 6)),
                Task.Run(() => DoOperation(1, 1, 1, 1, 2, 1, 1, 1)));
            foreach (var result in results)
                Console.WriteLine(result);

            Console.WriteLine("Запись в файл начата");
            await WriteFileAsync("C:\\Temp\\ispp21\\RandomNumber.txt", 100000);
            Console.WriteLine("Конец программы");
            await ReadFile("C:\\Temp\\ispp21\\RandomNumber.txt");
            /*
            CancellationTokenSource cts = new();
            CancellationToken token = cts.Token;

            try
            {
                cts.CancelAfter(1000);
                await ReadFile();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }*/
        }

        static void ShowPower(double a, int x)
        {
            double result = 1;
            if (x != 0)
            {
                int temp = x < 0 ? -x : x;
                for (int i = 0; i < temp; i++)
                    result *= a;
                if (x < 0)
                    result = 1 / result;
            }
            Console.WriteLine($"{a}^{x}={result}");
        }

        static double GetPower(double a, int x)
        {
            double result = 1;
            if (x != 0)
            {
                int temp = x < 0 ? -x : x;
                for (int i = 0; i < temp; i++)
                {
                    result = a * result;
                }
                if (x < 0)
                    result = 1 / result;
            }
            return result;
        }

        static double DoOperation(double a1, int x1, double a2, int x2, double a3, int x3, double a4, int x4)
        {
            return (GetPower(a1, x1) + GetPower(a2, x2)) / (GetPower(a3, x3) - GetPower(a4, x4));
        }

        static async Task WriteFileAsync(string path, int rowsCount)
        {
            Random random = new();
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                for (int i = 0; i < rowsCount; i++)
                    await writer.WriteLineAsync($"Число №{i + 1}: {random.Next()}");
            }
        }

        static async Task ReadFile(string path)
        {
            using (StreamReader reader = new StreamReader(path, false))
            {
                string line;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    Console.WriteLine($"{Path.GetFileName(path)}: {line}");
                }
            }
        }
    }
}
