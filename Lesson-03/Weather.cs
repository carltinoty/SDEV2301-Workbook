using static System.Console;

Write("Temperature: ");
int temperature = int.Parse(ReadLine() ?? "");

if (temperature >= 20)
{
    WriteLine("Warm");
}
else
{
    WriteLine("Cold");
}