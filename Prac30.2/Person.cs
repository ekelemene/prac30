using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac30._2
{
    /// <summary>
    /// абстрактный класс 
    /// </summary>
    abstract class Person
    {
        /// <summary>
        /// поле со свойством 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// абстрактный метод
        /// </summary>
        public abstract void SayHello();
    }
}
