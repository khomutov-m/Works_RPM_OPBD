namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();

            new HexObserver(subject);
            new OctalObserver(subject);
            new BinaryObserver(subject);
            new DecimalObserver(subject);

            Console.WriteLine("First state change: 15");
            subject.SetState(15);
            Console.WriteLine("Second state change: 10");
            subject.SetState(10);
        }
    }
}

