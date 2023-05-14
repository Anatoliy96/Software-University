int greenLightDuration = int.Parse(Console.ReadLine());
int freeWindowDuration = int.Parse(Console.ReadLine());

Queue<string> vs = new Queue<string>();

string commnad = Console.ReadLine();

int passedCars = 0;
int duration = 0;
bool isCrashed = false;

while (commnad != "END")
{
    if (commnad == "green")
    {
        if (greenLightDuration == 0)
        {
            commnad = Console.ReadLine();
            continue;
        }

        while (vs.Count > 0 && duration > 0)
        {
            if (vs.Peek().Length <= duration)
            {
                duration -= vs.Peek().Length;
                vs.Dequeue();
                passedCars++;
            }
            else
            {
                if (vs.Peek().Length <= duration + freeWindowDuration)
                {
                    vs.Dequeue();
                    passedCars++;
                    break;
                }
                else
                {
                    isCrashed = true;
                    Console.WriteLine("A crash happened!");
                    int indexCrashed = duration + freeWindowDuration;
                    string carText = vs.Peek();
                    string subs = carText.Substring(indexCrashed, 1);
                    Console.WriteLine($"{carText} was hit at {subs}.");
                    return;
                }
            }
        }
    }
    else
    {
        vs.Enqueue(commnad);
    }
    duration = greenLightDuration;
    commnad = Console.ReadLine();
}

if (!isCrashed)
{
    Console.WriteLine("Everyone is safe.");
    Console.WriteLine($"{passedCars} total cars passed the crossroads.");
}
        
