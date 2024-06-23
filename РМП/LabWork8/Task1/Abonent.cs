namespace Task1
{
    internal class Abonent
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

        public override string ToString() => $"ФИО: {FullName}\nНомер: {PhoneNumber}\nВремя разговоров: {TimeCall}";

        public override bool Equals(object? obj)
        {
            if (obj is Abonent abonent)
                return FullName == abonent.FullName && PhoneNumber == abonent.PhoneNumber && TimeCall == abonent.TimeCall;
            return false;
        }
    }
}
