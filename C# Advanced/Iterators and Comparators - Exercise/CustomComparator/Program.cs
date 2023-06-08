namespace CustomComparator
{
    public class StartUp
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Comparator comparator = new Comparator();

            Array.Sort(numbers, comparator);

            Console.WriteLine(String.Join(" ", numbers));
        }

        public class Comparator : IComparer<int>
        {
            public int Compare(int x, int y)
            {
                if (x % 2 == 0 && y % 2 != 0)
                {
                    return -1;
                }
                else if (x % 2 != 0 && y % 2 == 0)
                {
                    return 1;
                }
                else
                {
                    return x.CompareTo(y);
                }
            }
        }
    }
}