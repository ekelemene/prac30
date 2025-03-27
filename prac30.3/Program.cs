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
            //способ 1
            //Journal journal = new Journal("Наука", 1000, 120.5);
            //Newspaper newspaper = new Newspaper("Кулинария", 100, 2, 100);

            //способ 2
            //journal.Output();
            //Console.WriteLine($"стоимость тиража журнала: {journal.Cost()} рублей");
            //Console.WriteLine();
            //newspaper.Output();
            //Console.WriteLine($"стоимость тиража газеты: {newspaper.Cost()} рублей");

            //способ 3
            List<Printedproducts> pressa = new List<Printedproducts>();
            bool flag = true;
            do
            {
                Console.Write("Введите название печатнойпродукции (J или N): ");
                string metka = Console.ReadLine();
                switch (metka)
                {
                    case "j": case "J":
                        {
                            pressa.Add(Journal.Enter()); break;
                        }
                    case "n": case "N":
                        {
                            pressa.Add(Newspaper.Enter()); break;
                        }
                    default: { Console.WriteLine("Нет такой печатной продукции"); break; }
                }
                foreach (Printedproducts p in pressa)
                {
                    p.Output();
                    Console.WriteLine($"Стоимость тиража: {p.Cost()} руб");
                }
            }
            while (flag);
            Console.ReadLine();
        }
    }
}
