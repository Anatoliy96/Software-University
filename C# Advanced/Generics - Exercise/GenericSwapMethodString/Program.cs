using System.Text;

namespace GenericSwapMethodString
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<string> elemenets = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();

                elemenets.Add(text);
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
