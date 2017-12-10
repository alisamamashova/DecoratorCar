using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorCar
{
    class Audi : AutoBase
    {
        public Audi()
        {
            Description = "Audi A8 - автомобиль представительского класса";
        }
        public override double GetCost() 
        {
            return 31500;
        }
    }
}
