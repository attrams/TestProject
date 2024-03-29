/* Composite formatting */
using System.Globalization;

string first = "Hello";
string second = "World";

Console.WriteLine("{1} {0}!", first, second);
Console.WriteLine("{0} {0} {0}!", first, second);

/* Formatting currency */
decimal price = 123.45m;
int discount = 50;

Console.WriteLine($"Price: {price:C} (save {discount:C})");

/* Formatting numbers */
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N4} units");

/* Formatting percentages */
decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P1}");