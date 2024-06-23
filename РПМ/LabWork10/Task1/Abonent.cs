namespace Task1
{
    internal class Abonent : IComparable, IComparable<Abonent>, IEquatable<Abonent>, ICloneable
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
            => Console.WriteLine($"ФИО: {FullName}\nНомер телефона: {PhoneNumber}\nВремя разговоров: {TimeCall}\n");

        public int CompareTo(object? obj)
        {
            if (obj is Abonent abonent)
                return TimeCall.CompareTo(abonent.TimeCall);
            throw new ArgumentException();
        }

        public int CompareTo(Abonent? other)
        {
            if (other is Abonent abonent)
                return TimeCall.CompareTo(abonent.TimeCall);
            throw new ArgumentException();
        }

        public bool Equals(Abonent? other)
        {
            if (other is Abonent abonent)
                return FullName == other.FullName && PhoneNumber == other.PhoneNumber && TimeCall == other.TimeCall;
            throw new ArgumentException();
        }

        public object Clone() => new Abonent(FullName, PhoneNumber, TimeCall);
    }
}
