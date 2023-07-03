
List<string> result = new List<string>();

string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

for (int i = 0; i < input.Length; i++)
{
    string[] currentPair = input[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);

    try
    {
        string face = GetCardFace(currentPair[0]);

        CardSuit suit = GetCardSuit(currentPair[1]);

        Card card = new Card(face, suit);

        result.Add(card.ToString());
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine(ex.Message);
    }
}

Console.WriteLine(string.Join(" ", result));

string GetCardFace(string v)
{
    switch (v)
    {
        case "1":
            return "1";
        case "2":
            return "2";
        case "3":
            return "3";
        case "4":
            return "4";
        case "5":
            return "5";
        case "6":
            return "6";
        case "7":
            return "7";
        case "8":
            return "8";
        case "9":
            return "9";
        case "10":
            return "10";
        case "J":
            return "J";
        case "Q":
            return "Q";
        case "K":
            return "K";
        case "A":
            return "A";
        default:
            throw new ArgumentException("Invalid card!");
    }
}

CardSuit GetCardSuit(string v)
{
    switch (v)
    {
        case "S":
            return CardSuit.Spades;
        case "H":
            return CardSuit.Hearts;
        case "D":
            return CardSuit.Diamonds;
        case "C":
            return CardSuit.Clubs;
        default:
            throw new ArgumentException("Invalid card!");
    }
}

public class Card
{
    public Card(string cardFace, CardSuit cardSuit)
    {
        CardFace = cardFace;
        CardSuit = cardSuit;
    }

    public string CardFace { get; set; }
    public CardSuit CardSuit { get; set; }

    public override string ToString()
    {
        char viewSuit = '\u2663';

        switch (this.CardSuit) 
        {
            case CardSuit.Diamonds:
                viewSuit = '\u2666';
                break;
            case CardSuit.Hearts:
                viewSuit = '\u2665';
                break;
            case CardSuit.Spades:
                viewSuit = '\u2660';
                break;
            default:
                break;
        }

        return $"[{this.CardFace}{viewSuit}]";
    }
}

public enum CardSuit
{
    Clubs = 0,
    Diamonds = 1, 
    Hearts = 2,
    Spades = 3
}