using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        public static void ClassTaker(MyClass myClass)
        {
            myClass._change = "Changed";
        }

        public static void StruktTaker(MyStruct myStruct)
        {
            myStruct._change = "Changed";
        }

        static void Main(string[] args)
        {
            MyStruct myStruct;

            myStruct._change = "Not Changed";
            Console.WriteLine(myStruct._change);
            MyClass myClass = new MyClass();

            myClass._change = "Not Changed";
            Console.WriteLine(myClass._change);

            ClassTaker(myClass);
            StruktTaker(myStruct);
            Console.WriteLine(myClass._change);
            Console.WriteLine(myStruct._change);
            Console.ReadKey();
        }
    }
}
