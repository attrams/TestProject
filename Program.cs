/* Exercise - Use the string's IndexOfAny() and LastIndexOf() helper methods */
// string message = "(What if) I am (only interested) in the last (set of parentheses)?";
// int openingPosition = message.LastIndexOf('(');

// openingPosition += 1;
// int closingPositon = message.LastIndexOf(')');
// int length = closingPositon - openingPosition;

// Console.WriteLine(message.Substring(openingPosition, length));

// string message = "(What if) there are (more than) one (set of parentheses)?";

// while (true)
// {
//     int openingPosition = message.IndexOf('(');

//     if (openingPosition == -1)
//     {
//         break;
//     }

//     openingPosition += 1;
//     int closingPositon = message.IndexOf(')');
//     int length = closingPositon - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));

//     message = message.Substring(closingPositon + 1);
// }

// working with different types of symbol sets
// string message = "Help (find) the {opening symbols}";
// Console.WriteLine($"Searching THIS Message: {message}");

// char[] openSymbols = { '[', '{', '(' };

// int startPosition = 5;
// int openingPosition = message.IndexOfAny(openSymbols);
// Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

// openingPosition = message.IndexOfAny(openSymbols, startPosition);
// Console.WriteLine($"Found WITH using startPosition {startPosition}: {message.Substring(openingPosition)}");

string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";
char[] openSymbols = { '[', '{', '(' };

int closingPosition = 0;

while (true)
{
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1)
    {
        break;
    }

    string currentSymbol = message.Substring(openingPosition, 1);

    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
}