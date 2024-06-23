namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo(@"путь");
            FileInfo[] files = directory.GetFiles("*", SearchOption.AllDirectories);
        }
    }
}
