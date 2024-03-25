Random random = new Random();
string result = random.Next(0, 2) == 0 ? "heads" : "tails";

Console.WriteLine($"Result: {result}");