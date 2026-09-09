using static System.Console;

Write("What is your score? ");

int score = int.Parse(ReadLine() ?? "0");

if (score >= 50)
{
    WriteLine("Pass");
}