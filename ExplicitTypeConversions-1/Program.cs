// Explicit Type conversions
Console.WriteLine("Explicit Type Conversions: ");

string number = "20";

int convertedNumber = int.Parse(number);

Console.WriteLine(convertedNumber);



string dateInput = "Jan 1, 2009";
var parsedDate = DateTime.Parse(dateInput);
Console.WriteLine(parsedDate);