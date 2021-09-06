using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronBuilder_Kata2
{
    class CoffeeBuilder
    {
		private Coffee Coffee;

		public CoffeeBuilder() {
	
			Reset();
		}

		public CoffeeBuilder SetBlackCoffee() {
			Coffee.Sort = "Black";
			return this; 
		}
		public CoffeeBuilder SetCubanoCoffee() {
			Coffee.Sort = "Cubano";
			WithSugar("Brown");
			return this;
		}
		public CoffeeBuilder SetAntoccinoCoffee() {
			Coffee.Sort = "Americano";
			WithMilk(0.5);
			return this;
		}

		public CoffeeBuilder WithMilk(double fat) {
			Coffee.Milk.Add(new Milk(fat));
			return this;
		}
		public CoffeeBuilder WithSugar(string sort) {
			Coffee.Sugar.Add(new Sugar(sort));
			return this; 
		}

		public void Reset()
        {
			
			Coffee = new Coffee("", new List<Milk>(), new List<Sugar>());
        }
		public Coffee Build() {
			return Coffee;
		}
	}
}
