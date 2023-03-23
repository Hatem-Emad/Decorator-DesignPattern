using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Mocha : CondimentDecorator
    {
        Beverage? beverage;

        //public Mocha(Beverage? beverage):base(", Mocha")
        //{
        //    this.beverage = beverage;
        //}
        public Mocha(Beverage? beverage)
        {
            this.beverage = beverage;
            Description = beverage?.Description + ", Mocha";
        }
        public override double Cost() => beverage?.Cost() + 0.29 ?? 0;

        //public override string GetDescription() => beverage?.Description + ", Mocha";
    }
}
