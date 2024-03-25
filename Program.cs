/* 
    The following code reverses a string and counts the number of times a particular character appears.
 */
string message = "The quick brown fox jumps over the lazy dog.";
char[] charMessage = message.ToCharArray();
Array.Reverse(charMessage);

int letterCount = 0;

foreach (char i in charMessage)
{
    if (i == 'o')
    {
        letterCount++;
    }
}

string reversedMessage = new String(charMessage);
Console.WriteLine(reversedMessage);
Console.WriteLine($"'o' appears {letterCount} times.");