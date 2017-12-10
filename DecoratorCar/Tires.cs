using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorCar
{
    public class Tires : Options
    {
        private readonly AutoBase _autoBase;

        public Tires(AutoBase autoBase)
        {
            _autoBase = autoBase;
            if (autoBase != null) 
            {
                Description = autoBase.GetDescription() + " + Зимняя резина";
            }
        }

        public override double GetCost()
        {
            double cost = 600;
            if(_autoBase != null) 
            {
                cost += _autoBase.GetCost();    
            }
            return cost;
        }
    }
}
