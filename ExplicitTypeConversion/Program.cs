// Explicit Type Conversions
Console.WriteLine("Explicit Type Conversions");

Console.WriteLine("Double to Integer:");

int intNumber = 30;
double doubleNumber = 90.0987;

intNumber = (int)doubleNumber;

Console.WriteLine(intNumber);

Console.WriteLine("Float To Long:");

long longNumber = 50;
float floatNumber = 50.60f;
longNumber = Convert.ToInt64(floatNumber);
Console.WriteLine(longNumber);



