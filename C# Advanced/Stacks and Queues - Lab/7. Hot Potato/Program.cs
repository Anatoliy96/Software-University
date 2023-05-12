
string[] input = Console.ReadLine().Split(' ');

Queue<string> kids = new Queue<string>(input);

int count = int.Parse(Console.ReadLine());
int counter = 1;

while (kids.Count > 1)
{
    if (count == counter)
    {
        Console.WriteLine($"Removed {kids.Dequeue()}");
        counter = 1;
    }
    else
    {
        string currentKid = kids.Dequeue();
        kids.Enqueue(currentKid);
        counter++;
    }
}
Console.WriteLine($"Last is {kids.Dequeue()}");

