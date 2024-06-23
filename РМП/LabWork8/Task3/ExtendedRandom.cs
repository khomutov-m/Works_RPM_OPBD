namespace Task3
{
    internal class ExtendedRandom : Random
    {
        public int[] ArrayRandom(int amount, int min, int max)
        {
            int[] array = new int[amount];
            for (int i = 0; i < amount; i++)
            {
                array[i] = Next(min, max);
            }
            return array;
        }
    }
}