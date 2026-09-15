class Program
{
	static void Main()
	{
		Console.WriteLine(MaxValue(4, 9));
		Console.WriteLine(MaxValue(4.5, 9.2));
	}

	static int MaxValue(int a, int b)
    //MaxValue(4, 9) compares 4 and 9, then gives back the bigger number: 9.
		=> a > b ? a : b;
        //“Is a bigger than b? If yes, use a; otherwise, use b.”

	static double MaxValue(double a, double b)
		=> a > b ? a : b;
}