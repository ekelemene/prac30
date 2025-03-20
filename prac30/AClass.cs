using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac30
{
    /// <summary>
    /// абстрактный класс
    /// </summary>
    abstract class AClass
    {
        /// <summary>
        /// обычный метод с именем Method1
        /// </summary>
        public void Method1() => Console.WriteLine("обычный метод Method1 из абстрактного класса с именем  AClass");
        /// <summary>
        /// виртуальный метод
        /// </summary>
        public virtual void Method2() => Console.WriteLine("виртуальный метод Method2 из абстрактного класса с именем AClass");
        /// <summary>
        /// абстрактный метод 3
        /// </summary>
        public abstract void Method3();
        /// <summary>
        /// абстрактный метод 4
        /// </summary>
        public abstract void Method4();






    }
}
