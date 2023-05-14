int bulletPrice = int.Parse(Console.ReadLine());
int sizeOfGunBarrel = int.Parse(Console.ReadLine());
int[] bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] locks = Console.ReadLine().Split().Select(int.Parse).ToArray();
int intelligenceValue = int.Parse(Console.ReadLine());

int bulletsCount = 0;
int barrel = 0;

Queue<int> treasureLocks = new Queue<int>(locks);
Stack<int> revolverBullets = new Stack<int>(bullets);

while (treasureLocks.Count > 0 && revolverBullets.Count > 0)
{
    if (revolverBullets.Peek() <= treasureLocks.Peek())
    {
        bulletsCount++;
        barrel++;
        Console.WriteLine("Bang!");
        revolverBullets.Pop();
        treasureLocks.Dequeue();
    }
    else
    {
        bulletsCount++;
        barrel++;
        Console.WriteLine("Ping!");
        revolverBullets.Pop();
    }
    if (barrel == sizeOfGunBarrel)
    {
        if (revolverBullets.Count > 0)
        {
            Console.WriteLine("Reloading!");
            barrel = 0;
        }
    }
}

if (revolverBullets.Count == 0 && treasureLocks.Count > 0)
{
    Console.WriteLine($"Couldn't get through. Locks left: {treasureLocks.Count}");
}
else if (revolverBullets.Count >= 0 && treasureLocks.Count == 0)
{
    int bulletCost = bulletsCount * bulletPrice;
    int moneyEarned = intelligenceValue - bulletCost;

    Console.WriteLine($"{revolverBullets.Count} bullets left. Earned ${moneyEarned}");
}
