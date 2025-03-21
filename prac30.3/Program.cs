using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac30._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal("Наука", 1000, 120.5);
            Newspaper newspaper = new Newspaper("Кулинария", 100, 2, 100);

            journal.Output();
            Console.WriteLine($"стоимость тиража журнала: {journal.Cost()} рублей");
            Console.WriteLine();
            newspaper.Output();
            Console.WriteLine($"стоимость тиража газеты: {newspaper.Cost()} рублей");

            Console.ReadLine();
        }
    }
}
