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

        public void Print()
        {
            Console.WriteLine($"ФИО: {FullName}\nНомер: {PhoneNumber}\nВремя разговоров: {TimeCall}");
        }

        public static Abonent operator ++(Abonent abonent)
        {
            abonent.TimeCall++;
            return abonent;
        }

        public static Abonent operator +(Abonent abonent1, Abonent abonent2) 
            => new Abonent(abonent1.FullName, abonent1.PhoneNumber, abonent1.TimeCall + abonent2.TimeCall);

        public static bool operator ==(Abonent abonent1, Abonent abonent2)
            => abonent1.FullName == abonent2.FullName && abonent1.PhoneNumber == abonent2.PhoneNumber && abonent1.TimeCall == abonent2.TimeCall;

        public static bool operator !=(Abonent abonent1, Abonent abonent2)
            => abonent1.FullName != abonent2.FullName || abonent1.PhoneNumber != abonent2.PhoneNumber || abonent1.TimeCall != abonent2.TimeCall;

        public static bool operator true(Abonent abonent) => abonent.TimeCall >= 0;

        public static bool operator false(Abonent abonent) => abonent.TimeCall < 0;
    }
}
