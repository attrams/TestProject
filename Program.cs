string[] myStrings = ["I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices."];

foreach (string myString in myStrings)
{
    int periodLocation = myString.IndexOf(".");
    string newString = myString;
    string outputString;

    while (periodLocation != -1)
    {
        outputString = newString.Remove(periodLocation);
        newString = newString.Substring(periodLocation + 1).TrimStart();
        periodLocation = newString.IndexOf(".");
        Console.WriteLine(outputString);
    }

    if (newString.Length > 0)
    {
        Console.WriteLine(newString.Trim());
    }
}
// Console.WriteLine(myStrings[0].Substring(myStrings[0].IndexOf(".") + 1));