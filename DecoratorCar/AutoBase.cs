using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorCar 
{
    public abstract class AutoBase
    {
        protected String Description = "";

        public String GetDescription()
        {
            return Description;
        }
        public abstract double GetCost();
    }
}
