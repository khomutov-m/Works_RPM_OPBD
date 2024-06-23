namespace Task1
{
    internal class DescendingComparerAbonent : IComparer<Abonent>
    {
        public int Compare(Abonent? x, Abonent? y)
        {
            if (x is Abonent abonent1 && y is Abonent abonent2)
                return -abonent1.CompareTo(abonent2);
            throw new ArgumentException();
        }
    }
}
