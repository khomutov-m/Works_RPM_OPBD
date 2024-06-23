namespace Task1
{
    internal class Abonent(string fullName, long phoneNumber, int timeCall)
    {
        public object? this[string index]
        {
            get
            {
                index.Trim();
                if (index == "full name")
                    return fullName;
                if (index == "phone number")
                    return phoneNumber;
                if (index == "time call")
                    return timeCall;
                return null;
            }
        }

        public char this[int index] => index < 0 || index >= fullName.Length ? '\0' : fullName[index];
        public Abonent() : this("Иван Иванович Иванов", 79998887766, 100) { }

        public void Print()
        {
            Console.WriteLine($"ФИО: {fullName}\nНомер: {phoneNumber}\nВремя разговоров: {timeCall}");
        }
    }

}
