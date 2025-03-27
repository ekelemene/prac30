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
            Console.WriteLine($"газета: {Name} количество листов: {Nambersheets} цена листа: {Costsheet} тираж: {Circulation}");
        }

        public override double Cost()
        {
            return Nambersheets * Costsheet * Circulation;
        }

        public static Newspaper Enter()
        {
            Console.Clear();
            Console.Write("Введите название газеты: ");
            string name = Console.ReadLine();
            Console.Write("Введите количество листов: ");
            int count = int.Parse(Console.ReadLine());
            Console.Write("Введите стоимоссть 1 листа: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Введите тираж: ");
            int circulation = int.Parse(Console.ReadLine());
            return new Newspaper(name,count,price,circulation);
        }


    }
}
