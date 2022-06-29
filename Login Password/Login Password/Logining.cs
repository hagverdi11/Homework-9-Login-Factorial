using System;
using System.Collections.Generic;
using System.Text;

namespace Login_Password
{
    class Logining
    {
        internal static void MyLogin (string mail, string password)
        {
            if (mail == "cavid@code.edu.az" && password == "12345")
            {
                Console.WriteLine("Login succesfull");
            }
            else
            {
                Console.WriteLine("Please retype your mail or password");
            }
        }


    }
}
