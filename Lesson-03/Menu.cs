Console.Write("What is your choice? ");

int choice = int.Parse(Console.ReadLine() ?? "0");

switch (choice)
{
    case 1: Console.WriteLine("Add"); break;
    case 2: Console.WriteLine("View"); break;    
    default: Console.WriteLine("Invalid Choice"); break;
}