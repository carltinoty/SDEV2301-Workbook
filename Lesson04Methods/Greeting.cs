class Program
{
	static void Main()
	{
		Greet("Mina");
		Greet(greeting: "Welcome", name: "Mina");
	}

	static void Greet(string name, string greeting = "Hello")
	{
		Console.WriteLine($"{greeting}, {name}!");
	}
}

// If you give a greeting, it uses it. If you do not, it uses "Hello". The name "Mina" stays the same.