using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorCar
{
	class Bmw : AutoBase
	{
		public Bmw()
		{
			Description = "BMW M5 - спортивный автомобиль";
		}
		public override double GetCost()
		{
			return 55000;
		}
	}
}
