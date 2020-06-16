using System;
using System.Reflection;

static class Program
{
	public static void Main(string[] args)
	{
		Assembly asm = Assembly.Load(args[0]);

		foreach(Type t in asm.GetTypes())
			Console.WriteLine(t.Name);
	}
}
