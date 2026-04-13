using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetSampleDemo
{
    class BasicSyntax
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int x = 10;

            float y= 20.5f; // we need to add 'f' at the end of the number to indicate that it is a float literal.
                            // For double we can add 'd' at the end of the number to indicate that it is a double literal.
                            // If we don't add any suffix then it will be treated as a double by default.

            double z= 5.0;

            decimal a = 100.5m;  // we need to add 'm' at the end of the number to indicate that it is a decimal literal.

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.Write(z);
            Console.WriteLine(a);

            String name = "Adarsh Abhishek";
            char l= 'a';

            //char r=''  -----> (error) because empty character is not valid for char type.
            //                          But if we want to assign empty value to char type then we can use
            //                          null character '\0' or we can use space character ' '.


            Console.WriteLine(name.Length);
            Console.WriteLine(name[1]); 
            Console.WriteLine(name.ToUpper());

            Console.WriteLine(l);

            String str= Console.ReadLine(); // it will take input from the user and store it in the variable 'str'.
            Console.WriteLine(str);


        }
    }
}
