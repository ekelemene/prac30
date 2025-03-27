using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac30._3
{
/// <summary>
/// абстрактный класс
/// </summary>
    abstract class Printedproducts
    {
        string name;
        /// <summary>
        /// конструктор без апарметров
        /// </summary>
        public Printedproducts() { }
        /// <summary>
        /// с 1 парметром
        /// </summary>
        /// <param name="name"></param>
        public Printedproducts(string name) { Name = name; }
        /// <summary>
        /// свойство
        /// </summary>
        public string Name { get => name; set => name = value; }
        public abstract void Output();
        public abstract double Cost();
    }
}
