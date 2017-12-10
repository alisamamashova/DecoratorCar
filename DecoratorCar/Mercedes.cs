using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorCar
{
	class Mercedes : AutoBase
	{
		public Mercedes()
		{
			Description = "Mercedes-Benz E63 - суперкар";
		}
		public override double GetCost()
		{
			return 61500;
		}
	}
}
