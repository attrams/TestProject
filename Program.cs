/* Use the Remove() method */
// string data = "12345John Smith          5000  3  ";
// string updatedData = data.Remove(5, 20);
// Console.WriteLine(updatedData);

/* Use the Replace() method */
// string message = "This--is--ex-amp-le--da-ta";
// message = message.Replace("--", " ");
// message = message.Replace("-", "");

// Console.WriteLine(message);

/* Complete a challenge to extract, replace, and remove data from an input string */
const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here
int openingPosition = input.IndexOf("<span>");
openingPosition += 6;
int closingPostion = input.IndexOf("</span>");
int length = closingPostion - openingPosition;
quantity = $"Quantity: {input.Substring(openingPosition, length)}";
Console.WriteLine(quantity);

openingPosition = input.IndexOf("<div>");
openingPosition += 5;
closingPostion = input.IndexOf("</div>");
length = closingPostion - openingPosition;
output = $"Ouput: {input.Substring(openingPosition, length).Replace("&trade;", "&reg;")}";
Console.WriteLine(output);