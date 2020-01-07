using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public enum Colours
    {
        None,
        Red,
        Green,
        Purple
    }

    class Program
    {
        public static void Print(string stroka, int color)
        {
            Console.WriteLine(Enum.GetName(typeof(Colours), color));
            Console.WriteLine(stroka);
        }

        static void Main(string[] args)
        {
            Print("Allo", 1);


            Console.ReadKey();
        }
    }
}
