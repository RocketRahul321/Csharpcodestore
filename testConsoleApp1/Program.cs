using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testConsoleApp1
{
    internal class Program
    {
        //string name= "John Doe";
        static void Main(string[] args)
        {
            //variable part
            /* string name = "John Doe";//reference type
             int number = 15;//4byte
             double decimalNumber = 15.5;//8byte
             char singleCharacter = 'A';//1byte
             bool isTrue = true;//1byte
             isTrue = false;
             //constant variable
             const float pi = 3.14f;//4byte
            */



            //print part 
            //Console.WriteLine("Hello World!");
            //Console.WriteLine(3 + 3);
            // this used for single line comment
            /*this is used for multy line comment 
             * and this is good for note taking */

            // "/" this is called as forward slash

            /*
            Console.WriteLine(name);
            Console.WriteLine(number);
            Console.WriteLine(decimalNumber);
            Console.WriteLine(singleCharacter);
            Console.WriteLine(isTrue);
            Console.WriteLine(pi);
            //Console.WriteLine();
            //Console.WriteLine();
            */
            //implecit type casting
            //char<int<long<float<double


            char mychar = 'A';
            int myint2 = mychar; // implicit conversion from char to int
            Console.WriteLine(myint2);

            int myint = 10;
            long mydouble = myint; // implicit conversion from int to double
            Console.WriteLine(mydouble);

            long mylong = 100;
            float myfloat = mylong; // implicit conversion from long to float
            Console.WriteLine(myfloat);

            float myfloat2 = 12.5f;
            double mydouble2 = myfloat2; // implicit conversion from float to double
            Console.WriteLine(mydouble2);
            //there is no use of f in double type

        }
    }
}
