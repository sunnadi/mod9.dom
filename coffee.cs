using System;

namespace CafeOrderSystem
{
    public abstract class Beverage
    {
        public abstract double Cost();
        public abstract string GetDescription(); 
    }
    public class Espresso : Beverage
    {
        public override double Cost()
        {
            return 500.0;
        }

        public override string GetDescription()
        {
            return "Эспрессо";
        }
    }

    public class Tea : Beverage
    {
        public override double Cost()
        {
            return 300.0;
        }

        public override string GetDescription()
        {
            return "Чай";
        }
    }
    public class Latte : Beverage
    {
        public override double Cost()
        {
            return 700.0;
        }

        public override string GetDescription()
        {
            return "Латте";
        }
    }

    public abstract class BeverageDecorator : Beverage
    {
        protected Beverage _beverage;

        public BeverageDecorator(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override double Cost()
        {
            return _beverage.Cost();
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription();
        }
    }

    public class Milk : BeverageDecorator
    {
        public Milk(Beverage beverage) : base(beverage) { }

        public override double Cost()
        {
            return base.Cost() + 100.0;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Молоко";
        }
    }
    public class Sugar : BeverageDecorator
    {
        public Sugar(Beverage beverage) : base(beverage) { }

        public override double Cost()
        {
            return base.Cost() + 50.0;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Сахар";
        }
    }
    public class WhippedCream : BeverageDecorator
    {
        public WhippedCream(Beverage beverage) : base(beverage) { }

        public override double Cost()
        {
            return base.Cost() + 150.0;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Взбитые сливки";
        }
    }
    public class Syrup : BeverageDecorator
    {
        public Syrup(Beverage beverage) : base(beverage) { }

        public override double Cost()
        {
            return base.Cost() + 120.0;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ", Сироп";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Beverage myBeverage = new Latte();
            Console.WriteLine($"{myBeverage.GetDescription()} : {myBeverage.Cost()} тг.");

            myBeverage = new Milk(myBeverage);
            Console.WriteLine($"{myBeverage.GetDescription()} : {myBeverage.Cost()} тг.");

            myBeverage = new Sugar(myBeverage);
            Console.WriteLine($"{myBeverage.GetDescription()} : {myBeverage.Cost()} тг.");

            myBeverage = new Syrup(myBeverage);
            Console.WriteLine($"{myBeverage.GetDescription()} : {myBeverage.Cost()} тг.");

            myBeverage = new WhippedCream(myBeverage);
            Console.WriteLine($"{myBeverage.GetDescription()} : {myBeverage.Cost()} тг.");
        }
    }
}
