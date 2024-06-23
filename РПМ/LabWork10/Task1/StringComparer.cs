namespace Task1
{
    internal class StringComparerAbonent : IComparer<Abonent>
    {
        public int Compare(Abonent? x, Abonent? y)
        {
            if (x is Abonent abonent1 && y is Abonent abonent2)
                return abonent1.FullName.CompareTo(abonent2.FullName);
            throw new ArgumentException();
        }
    }
}
