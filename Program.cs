// int myInt = 3;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = myInt;
// Console.WriteLine($"decimal: {myDecimal}");

// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");

// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");

/* type casting */
// decimal myDecimal = 1.23456789m;
// float myFloat = (float)myDecimal;

// Console.WriteLine($"Decimal: {myDecimal}");
// Console.WriteLine($"Float: {myFloat}");

/* Converting string to an int using parse() */

// string first = "5";
// string second = "7";
// int sum = int.Parse(first) + int.Parse(second);

// Console.WriteLine(sum);

/* Converting string to an int using Convert class */
// string value1 = "5";
// string value2 = "7";
// int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);

// Console.WriteLine(result);

/* Compare casting and converting a decimal into an int */
// int value = (int)1.5m;
// Console.WriteLine(value);

// int value2 = Convert.ToInt32(1.5m);
// Console.WriteLine(value2);

/* Examining the TryParse() method */
// string value = "bad";
// int result = 0;

// if (int.TryParse(value, out result))
// {
//     Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//     Console.WriteLine("Unable to report the measurement.");
// }

// if (result > 0)
// {
//     Console.WriteLine($"Measurement (w/ offset): {50 + result}");
// }

/* Exercise - combine string array values as strings and as integers */
// string[] values = { "12.3", "45", "ABC", "11", "DEF" };
// string stringsInValues = "";
// decimal numbersInValues = 0m;

// foreach (string value in values)
// {
//     decimal temp = 0;
//     if (decimal.TryParse(value, out temp))
//     {
//         numbersInValues += temp;
//     }
//     else
//     {
//         stringsInValues += value;
//     }
// }

// Console.WriteLine($"Message: {stringsInValues}");
// Console.WriteLine($"Total: {numbersInValues}");

/* Exercise - output math operations as specific number types */
int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
int result1 = value1 / Convert.ToInt32(value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
decimal result2 = value2 / Convert.ToDecimal(value3);
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
float result3 = value3 / (float)value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");