namespace Task4
{
    internal class Patient(string fullName, long policy, DateTime dateBirth)
    {
        public string FullName { get; set; } = fullName;
        public string Policy { get; set; } = Convert.ToString(policy).PadLeft(9, '0');
        public DateTime DateBirth { get; set; } = dateBirth;

        public override string ToString() => String.Format("{0}\n{1}\n{2:d}", FullName, Policy, DateBirth);
    }
}
