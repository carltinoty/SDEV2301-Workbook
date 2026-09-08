//Parse Text Before doing Arithmetic
Console.Write("Rate: ");
decimal rateInput = Console.ReadLine() ?? "";
int rate = int.Parse(rateInput);

Console.Write("Hours: ");
string hoursInput = Console.ReadLine() ?? "";
int hours = int.Parse(hoursInput);

Console.WriteLine($"Gross Pay: {rate * hours}");