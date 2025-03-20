using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac30
{
    /// <summary>
    /// абстрактный класс наследованный от Акласс
    /// </summary>
    class DerivedClass : AClass
    {
        /// <summary>
        /// переопределенный виртуальный метод с именем метод2
        /// </summary>
        public override void Method2()
        {
            base.Method2();
            Console.WriteLine("метод Method2 из класса Аклас реаизованный в произв классе DerivedClass");
        }
        /// <summary>
        /// реализованный переопределенный абстрактный метод с именем метод3
        /// </summary>
        public override void Method3()
        {
            Console.WriteLine("метод с именем метод3 из класса Акласс реализованный в производном классе DerivedClass");
        }
        /// <summary>
        /// реализованный переопределенный абстрактный метод  с именем метод4
        /// </summary>
        public override void Method4()
        {
            Console.WriteLine("метод с именем метод4 из класса Акласс реализованный в производном классе DerivedClass");
        }




    }
}
