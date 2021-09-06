using System;
using System.Collections.Generic;
using System.Linq;

namespace PatronBuilder_Kata2
{

	public static class SampleTests
	{
		public static void Test1()
		{
			var actual = new CoffeeBuilder().SetBlackCoffee().WithSugar("Regular").WithMilk(3.2).Build();
			var expected = new Coffee("Black", new List<Milk> { new Milk(3.2) }, new List<Sugar> { new Sugar("Regular") });
			Console.WriteLine($"expected: {expected}");
			Console.WriteLine($"actual: {actual}");

			bool assertAreEqual = expected.ToString() == actual.ToString();
			Console.WriteLine("Test " + (assertAreEqual ? " -------- ok" : " -------------- FAIL"));
		}

		public static void Test2()
		{
			var actual = new CoffeeBuilder().SetAntoccinoCoffee().Build();
			var expected = new Coffee("Americano", new List<Milk> { new Milk(0.5) }, new List<Sugar>());
			Console.WriteLine($"expected: {expected}");
			Console.WriteLine($"actual: {actual}");

			bool assertAreEqual = expected.ToString() == actual.ToString();
			Console.WriteLine("Test " + (assertAreEqual ? " -------- ok" : " -------------- FAIL"));
		}

		public static void Test3()
		{
			var actual = new CoffeeBuilder().SetCubanoCoffee().Build();
			var expected = new Coffee("Cubano", new List<Milk>(), new List<Sugar> { new Sugar("Brown") });
			Console.WriteLine($"expected: {expected}");
			Console.WriteLine($"actual: {actual}");

			bool assertAreEqual = expected.ToString() == actual.ToString();
			Console.WriteLine("Test " + (assertAreEqual ? " -------- ok" : " -------------- FAIL"));
		}
	}

	internal class Program
	{
		private static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine(@"
To run tests write:
testAll
test1
test2
test3
					");
				var instrucction = Console.ReadLine();
				if (instrucction == "testAll")
				{
					SampleTests.Test1();
					SampleTests.Test2();
					SampleTests.Test3();
				}
				else if (instrucction == "test1")
					SampleTests.Test1();
				else if (instrucction == "test2")
					SampleTests.Test2();
				else if (instrucction == "test3")
					SampleTests.Test3();
				}
		}

		
	}
}