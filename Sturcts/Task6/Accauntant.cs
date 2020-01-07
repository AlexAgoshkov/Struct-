using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Accauntant
    {
        public bool AskForBonus(Jobs jobs, int hours)
        {
            bool result = false;

            if ((int)jobs < hours)
            {
                result = true;
            }


            return result;
        }
    }
}
