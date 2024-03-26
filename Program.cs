string? userInput;
int parseInput = 0;

bool validInput = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    userInput = Console.ReadLine();
    validInput = int.TryParse(userInput, out parseInput);

    if (validInput)
    {
        if ((parseInput > 5) && (parseInput < 10))
        {
            Console.WriteLine($"Your input value ({parseInput}) has been accepted.");
        }
        else
        {
            Console.WriteLine($"You entered {parseInput}. Please enter a number between 5 and 10.");
            validInput = false;
        }
    }
    else
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
} while (validInput == false);