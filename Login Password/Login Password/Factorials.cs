using System;
using System.Collections.Generic;
using System.Text;

namespace Login_Password
{
    class Factorials
    {
        internal static void MyFactorials(int number)
        {
            int i; int fact = 1;
            for (i = 1; i <= number; i ++)
            {
                fact = fact * i;
            }

            Console.WriteLine(fact);
        }
        

    }
}
