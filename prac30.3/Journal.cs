using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac30._3
{
    class Journal : Printedproducts
    {
        int circulation;
        double price;
        public int Circulation { get => circulation; set => circulation = value; }
        public double Price { get => price; set => price = value; }

        public Journal() { }
        public Journal(string name, int circulation, double price) : base(name)
        {
            this.Circulation = circulation;
            this.Price = price;
        }

        public override void Output()
        {
            Console.WriteLine($"журнал: {Name} тираж: {Circulation} цена: {Price}");
        }

        public override double Cost()
        {
            return Circulation * Price;
        }
    }
}
