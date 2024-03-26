string? userInput;
bool validInput = false;

Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

do
{
    userInput = Console.ReadLine().Trim().ToLower();

    switch (userInput)
    {
        case "administrator":
        case "manager":
        case "user":
            validInput = true;
            break;
        default:
            Console.WriteLine($"The role name that you entered, \"{userInput}\" is not valid. Enter your role name (Administrator, Manager, or User)\t");
            break;
    }
} while (validInput == false);

Console.WriteLine($"Your input value ({userInput}) has been accepted.");