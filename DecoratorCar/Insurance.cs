using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorCar
{
    public class Insurance : Options
    {
        private readonly AutoBase _autoBase;

        public Insurance(AutoBase autoBase)
        {
            _autoBase = autoBase;
            if (autoBase != null)
            {
                Description = autoBase.GetDescription() + " + Страховка на год";
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
