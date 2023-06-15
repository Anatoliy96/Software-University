string[] names = Console.ReadLine().Split(' ');

Action<string> action = (a) => Console.WriteLine("Sir" + " " + a);

names.ToList().ForEach(a => action(a));
