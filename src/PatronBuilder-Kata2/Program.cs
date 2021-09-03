using System;
using System.Collections.Generic;
using System.Linq;

namespace PatronBuilder_Kata2
{
	public class Coffee
	{
		public string Sort { get; set; }
		public List<Milk> Milk { get; set; }
		public List<Sugar> Sugar { get; set; }

		public Coffee(string sort, List<Milk> milk, List<Sugar> sugar)
		{
			Sort = sort;
			Milk = milk;
			Sugar = sugar;
		}
		public override string ToString()
		{			
			string milk = string.Join(", ", Milk.Select(e => e.ToString()).ToArray());
			string sugar = string.Join(", ", Sugar.Select(e => e.ToString()).ToArray());
			return $"Coffee: {Sort}. {milk} {sugar}";
		}
	}

	public class Milk
	{
		public readonly double Fat;

		public Milk(double fat)
		{
			Fat = fat;
		}
		public override string ToString()
		{
			return $"Milk: {Fat}.";
		}
	}

	public class Sugar
	{
		public readonly string Sort;

		public Sugar(string sort)
		{
			Sort = sort;
		}
		public override string ToString() {
			return $"Sugar: {Sort}.";
		}
	}
	class CoffeeBuilder
	{
		public CoffeeBuilder() { }

		public CoffeeBuilder SetBlackCoffee() { return this; }
		public CoffeeBuilder SetCubanoCoffee() { return this; }
		public CoffeeBuilder SetAntoccinoCoffee() { return this; }

		public CoffeeBuilder WithMilk(double fat) { return this; }
		public CoffeeBuilder WithSugar(string sort) { return this; }

		public Coffee Build() { return new Coffee("", new List<Milk>(), new List<Sugar>()); }
	};

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