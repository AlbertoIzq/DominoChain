using DominoChain;

try
{
    Console.WriteLine("Domino chain solver app\n");

    Console.WriteLine("Introduce the set of dominos, one by one like \"1 2\"" +
        "and press enter after each one. When you have finished, write \"end\":");

    var dominos = new List<(int, int)>();

    string input = Console.ReadLine();

    while (!input.Equals("end"))
    {
        dominos.Add(Utilities.ParseToTuple(input));
        input = Console.ReadLine();
    }

    Console.WriteLine("");
    Console.Write("Your domino set is:");

    for (int i = 0; i < dominos.Count; i++)
    {
        Console.Write(" ");
        Console.Write($"[{dominos[i].Item1} {dominos[i].Item2}]");
    }

    Console.WriteLine("\n");

    // Try to find a circular chain
    var chain = Utilities.FindCircularChain(dominos);

    if (chain != null)
    {
        Console.WriteLine("The found circular domino chain is:");
        foreach (var domino in chain)
        {
            Console.Write($"[{domino.Item1}|{domino.Item2}] ");
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