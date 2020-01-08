using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    struct Time
    {
        public int Days(DateTime date)
        {
            int result = 0;

            DateTime dt = new DateTime(date.Year, date.Month, date.Day);

            result = DateTime.Now.Subtract(dt).Days;

            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter DOB (dd/mm): ");
            string dob = "06/02/"; //Console.ReadLine();
            dob += DateTime.Now.Year;
            DateTime dt = DateTime.Parse(dob);

            Time time; 

            Console.WriteLine(time.Days(dt) * -1);

            Console.ReadKey();
        }
    }
}
