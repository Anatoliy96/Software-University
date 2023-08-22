using Telephony;

string[] phoneInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
string[] urlInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

foreach (var phoneNumber in phoneInput)
{
	if (phoneNumber.Length == 10)
	{
		ICallable smartphone = new Smartphone();

		Console.WriteLine(smartphone.Calling(phoneNumber));
	}
	else if (phoneNumber.Length == 7)
	{
		ICallable stationaryPhone = new StationaryPhone();

        Console.WriteLine(stationaryPhone.Calling(phoneNumber));
    }
}

foreach (var url in urlInput)
{
	IBrowsable smartphone = new Smartphone();

    Console.WriteLine(smartphone.Browse(url));
}
