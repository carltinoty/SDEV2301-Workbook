//Parse Text Before doing Arithmetic
Console.Write("Hours: ");
string Input = Console.ReadLine() ?? "";
double hours = double.Parse(Input);

Console.WriteLine($"Hours entered: {hours}");