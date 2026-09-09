//Parse Text Before doing Arithmetic
Console.Write("Rate: ");
string rateInput = Console.ReadLine() ?? "";
decimal rate = decimal.Parse(rateInput);

Console.Write("Hours: ");
string hoursInput = Console.ReadLine() ?? "";
decimal hours = decimal.Parse(hoursInput);

Console.WriteLine($"Gross Pay: ${rate * hours}");