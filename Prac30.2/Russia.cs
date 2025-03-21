using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac30._2
{
    /// <summary>
    /// наследуемый класс 
    /// </summary>
    class Russia : Person
    {
        /// <summary>
        /// конструктор 
        /// </summary>
        /// <param name="name"></param>
        public Russia(string name) { Name = name; }
        /// <summary>
        /// реализованный метод 
        /// </summary>
        public override void SayHello()
        {
            Console.WriteLine($"{Name} Приветствую");
        }
    }
}
