using static System.Console; //Enables access to all static --SO WE DON'T NEED TO USE "Console" all the time
//Prompt for age 
Write("What is your age? ");

int age = int.Parse(ReadLine() ?? "0");

if (age >= 18)
{
    Console.WriteLine("Adult");
}
else
{
    Console.WriteLine("Minor");
}