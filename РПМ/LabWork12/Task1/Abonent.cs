namespace Task1
{
    struct Abonent
    {
        private string _fullName;
        private long _phoneNumber;
        private int _timeCall;
        public Rate rate;

        public string FullName
        {
            get => _fullName;
            set
            {
                value = value.Trim();
                if (value.Length > 0)
                    _fullName = value;
            }
        }

        public long PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                if (value >= 0)
                    _phoneNumber = value;
            }
        }

        public int TimeCall
        {
            get => _timeCall;
            set
            {
                if (value >= 0)
                    _timeCall = value;
            }
        }

        public Abonent(string fullName, long phoneNumber, int timeCall)
        {
            FullName = fullName;
            PhoneNumber = phoneNumber;
            TimeCall = timeCall;
            rate = Rate.TimeBased;
        }

        public Abonent() : this("Иван Иванович Иванов", 79998887766, 100) { }

        public void Print()
            => Console.WriteLine($"ФИО: {FullName}\nНомер телефона: {PhoneNumber}\nВремя разговоров: {TimeCall}\nТариф: {rate}\nЦена: {(int)rate}");
    }
}
