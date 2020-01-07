using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public enum Jobs
    {
        None = 0,
        Boss = 160,
        BigBoss = 140,
        VeryBigBoss = 40
    }

    class Program
    {
        static void Main(string[] args)
        {
            Accauntant accauntant = new Accauntant();

            if (accauntant.AskForBonus(Jobs.BigBoss, 140))
            {
                Console.WriteLine("TRUE");
            }
            else
            {
                Console.WriteLine("FALSE");
            }

            Console.ReadKey();
        }
    }
}
