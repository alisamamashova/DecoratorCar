using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorCar
{
	public class Engine : Options
	{
		private readonly AutoBase _autoBase;

		public Engine(AutoBase autoBase)
		{
			_autoBase = autoBase;
			if (autoBase != null)
			{
				Description = autoBase.GetDescription() + " + Усиленный двигатель";
			}
		}

		public override double GetCost()
		{
			double cost = 25000;
			if (_autoBase != null)
			{
				cost += _autoBase.GetCost();
			}
			return cost;
		}
	}
}
