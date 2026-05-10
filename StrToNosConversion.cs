using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSampleDemo
{
    class StrToNosConversion
    {
        public static void Main(string[] args)
        {
            string str1 = "123";
            int num1 = int.Parse(str1); // it will convert the string "123" to integer 123.
            Console.WriteLine(num1);

            string str2 = "-93";
            int num2 = Convert.ToInt32(str2); // it will convert the string "123.45" to integer 123 by truncating the decimal part.
            Console.WriteLine(num2);

            string str3 = "78.89";
            double num3 = Convert.ToDouble(str3); // it will convert the string "123.45" to double 123.45 by keeping the decimal part.
            Console.WriteLine(num3);
             
            string str4 = "5.00003";
            float num4 = Convert.ToSingle(str4); // it will convert the string "5.00003" to float 5.00003 by keeping the decimal part.
            Console.WriteLine(num4);

            string str5 = "100.5";
            decimal num5 = Convert.ToDecimal(str5); // it will convert the string "100.5" to decimal 100.5 by keeping the decimal part.
            Console.WriteLine(num5);

        }
    }
}
