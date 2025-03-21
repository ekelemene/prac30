using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac30._3
{
    class Newspaper : Printedproducts
    {
        int nambersheets;
        double costsheet;
        int circulation;
        public int Nambersheets { get => nambersheets; set => nambersheets = value; }
        public double Costsheet { get => costsheet; set => costsheet = value; }
        public int Circulation { get => circulation; set => circulation = value; }

        public Newspaper(string name, int nambersheets, double costsheet, int circulation ): base (name) 
        {
            Nambersheets = nambersheets;
            Costsheet = costsheet;
            Circulation = circulation;
        }
        public override void Output()
        {
            Console.WriteLine($"журнал: {Name} количество листов: {Nambersheets} цена листа: {Costsheet} тираж: {Circulation}");
        }

        public override double Cost()
        {
            return Nambersheets * Costsheet * Circulation;
        }

    }
}
