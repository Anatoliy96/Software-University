namespace Froggy
{
    public class StartUp
    {
        public static void Main()
        {
            int[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Lake lake = new Lake();

            foreach (var item in input)
            {
                lake.Add(item);
            }

            foreach (var rock in lake)
            {
                string result = string.Join(", ", lake);
                Console.WriteLine(result);
                return;
            }
        }
    }
}
