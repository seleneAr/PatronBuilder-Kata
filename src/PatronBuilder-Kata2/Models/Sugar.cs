using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronBuilder_Kata2
{
    class Sugar
    {
		public readonly string Sort;

		public Sugar(string sort)
		{
			Sort = sort;
		}
		public override string ToString()
		{
			return $"Sugar: {Sort}.";
		}
	}
}
