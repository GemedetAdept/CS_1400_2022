// Alter a self-referencing variable
int x = 0;

x = int.Parse(Console.ReadLine()); // Parse input as an integer instead of string
x = x+18; // Add
x = x-5; // Subtract
x = x%2; // Modulo

Console.WriteLine(x);

// Add variables together
int bal = 1000;
int balDelta = 50;
int total = bal + balDelta;
Console.WriteLine(total);
