using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac30._2
{
    class Mongolia : Person
    {
        public Mongolia(string name) { Name = name;}
        public override void SayHello()
        {
            Console.WriteLine($"{Name} Приветствую");
        }
    }
}
