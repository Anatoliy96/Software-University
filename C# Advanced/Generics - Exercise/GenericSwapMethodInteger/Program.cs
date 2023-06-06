namespace GenericSwapMethodInteger
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<int> elemenets = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                elemenets.Add(number);
            }

            int[] indexes = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int index1 = indexes[0];
            int index2 = indexes[1];

            SwapElements(elemenets, index1, index2);

            foreach (var element in elemenets)
            {
                Console.WriteLine($"{element.GetType().FullName}: {element}");
            }
        }

        public static T SwapElements<T>(List<T> elements, int index1, int index2)
        {
            T temp = elements[index1];
            elements[index1] = elements[index2];
            elements[index2] = temp;

            return temp;
        }
    }
}
