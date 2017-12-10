using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorCar
{
    public class Mehendi : Options
    {
        private readonly AutoBase _autoBase;

        public Mehendi(AutoBase autoBase)
        {
            _autoBase = autoBase;
            if (autoBase != null)
            {
                Description = autoBase.GetDescription() + " + Роспись автомобиля";
            }
        }

        public override double GetCost()
        {
            double cost = 500;
            if (_autoBase != null)
            {
                cost += _autoBase.GetCost();
            }
            return cost;
        }
    }
}
