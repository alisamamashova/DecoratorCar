using System;

namespace DecoratorCar
{
    class Program
    {
        static void Main(string[] args)
        {
            var auto1 = new Bmw();
            var auto2 = new Audi();

            PrintAuto(auto1);
            PrintAuto(auto2);
            PrintLine();

            var auto3 = new Insurance(new Bmw());
            var auto4 = new Conditioner(new Tires(new Audi()));
            var auto5 = new Tires(new Conditioner(new Insurance(new Bmw())));
            var auto6 = new Engine(new Conditioner(new Tires(new Audi())));
            var auto7 = new Engine(new Tires(new Mercedes()));
            var auto8 = new Mehendi(new Tires(new Audi()));

			PrintAuto(auto3);
			PrintAuto(auto4);
			PrintAuto(auto5);
            PrintAuto(auto6);
            PrintAuto(auto7);
            PrintAuto(auto8);

        }
        public static void PrintAuto(AutoBase auto) 
        {
            Console.WriteLine("{0} \nСтоимость: {1}$", auto.GetDescription(), auto.GetCost());
            PrintLine();
        }
        public static void PrintLine() 
        {
            Console.WriteLine("------------------------");
        }
    }
}
