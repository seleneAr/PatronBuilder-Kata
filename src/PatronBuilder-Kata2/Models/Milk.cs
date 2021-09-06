using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronBuilder_Kata2
{
    class Milk
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
}
