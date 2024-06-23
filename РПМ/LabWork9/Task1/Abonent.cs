namespace Task1
{
    internal class Abonent : IPrinter
    {
        public string FullName { get; set; }
        public long PhoneNumber { get; set; }
        public int TimeCall { get; set; }

        public Abonent(string fullName, long phoneNumber, int timeCall)
        {
            FullName = fullName;
            PhoneNumber = phoneNumber;
            TimeCall = timeCall;
        }

        public Abonent() : this("Иван Иванович Иванов", 79998887766, 100) { }

        public void Print()
            => Console.WriteLine($"ФИО: {FullName}\nНомер телефона: {PhoneNumber}\nВремя разговоров: {TimeCall}");
    }
}
