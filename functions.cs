using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;


//Public: Allows for access in other files
//Private: Allows for access only in class definition
//static: No need for instantiation (ex. no need for        int number = new int() )

namespace ConcentrationFinderApp
{
    public class functions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="currentUnit"></param>
        /// <param name="num1"></param>
        /// <returns></returns>
        public static bool Convert(string currentUnit, ref double num1)
        {
            if (currentUnit == "ug")
            {
                num1 /= 1000;
            }
            else if (currentUnit == "g")
            {
                num1 *= 1000;
            }
            else if (currentUnit == "kg")
            {
                num1 *= 1000000;
            }
            else if (currentUnit == "lb")
            {
                num1 *= 453592;
            }
            return true;
        }
    }
}