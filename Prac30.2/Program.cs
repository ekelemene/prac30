using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac30._2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            people.Add(new Russia("Petya"));
            people.Add(new Ukraine("Jenya"));
            people.Add(new Mongolia("Rahmed"));
            foreach(Person person in people)
            {
                person.SayHello();
            }
            Console.ReadKey();

        }
    }
}
