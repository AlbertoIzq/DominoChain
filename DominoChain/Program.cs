using DominoChain;

try
{
    Console.WriteLine("Domino chain solver app\n");

    Console.WriteLine("Introduce the set of dominos, one by one like \"1 2\"" +
        "and press enter after each one. When you have finished, write \"end\":");

    var dominos = new List<Domino>();

    string input = Console.ReadLine();

    while (!input.Equals("end"))
    {
        dominos.Add(Utilities.ParseToDomino(input));
        input = Console.ReadLine();
    }

    Console.WriteLine("");
    Console.Write("Your domino set is:");

    for (int i = 0; i < dominos.Count; i++)
    {
        Console.Write(" ");
        Console.Write(dominos[i].ToString());
    }

    Console.WriteLine("\n");

    // Try to find a circular chain
    var chain = Utilities.FindCircularChain(dominos);

    if (chain != null)
    {
        Console.WriteLine("The found circular domino chain is:");
        foreach (var domino in chain)
        {
            Console.Write(domino.ToString());
        }
    }
    else
    {
        Console.WriteLine("A circular domino chain is not possible.");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"\nException: {ex.Message}");
}