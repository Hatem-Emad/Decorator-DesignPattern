using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class WhipedMilk : CondimentDecorator
    {
        Beverage? beverage;
        //public WhipedMilk(Beverage? beverage):base(", WhipedMilk")
        //{
        //    this.beverage = beverage;
        //}
        public WhipedMilk(Beverage? beverage)
        {
            this.beverage = beverage;
            Description = beverage?.Description + ", WhipedMilk";
        }
        public override double Cost() => beverage?.Cost() + 0.39 ?? 0;

        //public override string GetDescription() => beverage?.Description + ", WhipedMilk";
    }
}
