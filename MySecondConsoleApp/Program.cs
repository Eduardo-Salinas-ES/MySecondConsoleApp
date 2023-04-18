using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySecondConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            OperatorExamples();
            myLoop();

            TryAnIf();
            TrySomeLoops();
            TryAnIfElse();

            Console.ReadLine();
        }

        private static void TryAnIfElse()
        {
            int x = 5;
            if (x == 10)
            {
                Console.WriteLine("x must be 10");
            }
            else
            {
                Console.WriteLine("x isn't 10");
            }
        }

        private static void TrySomeLoops()
        {
            int count = 0;
            while(count < 10)
            {
                count = count + 1;
            }
            for(int i = 0; i < 5;i++)
            {
                count = count - 1;
            }
            Console.WriteLine("The answer is " + count);
        }


        private static void TryAnIf()
        {
            int someVAlue = 4;
            string name = "Bobbo Jr.";
            if((someVAlue == 3) && (name == "Joe"))
            {
                Console.WriteLine("x is 3 and the name is Joe");
            }
            Console.WriteLine("this line runs no matter what");
        }

        private static void myLoop()
        {
            int p = 2;
            for (int q = 2; q < 32; q = q * 2)
            {
                while(p < q)
                {
                    p = p * 2;

                }
                q = p - q;
            }
        }

        private static void OperatorExamples()
        {
            // Declare and intialize width variable of type int and intializes
            // it to 3
            int width = 3;

            // The ++ operator increments a variable (adds 1 to it)
            width++;

            // Declare two more int variables to hold numbers and 
            // use the + and * operators to add and multiply values
            int height = 2 + 4;
            int area = width * height;
            Console.WriteLine(area);

            while (area < 50)
            {
                height++;
                area = width * height;
            }

            do
            {
                width--;
                area = width * height;


            } while (area > 25);

            

            // The next two statements declare string variables
            // and use + to concatenate them (join them together)
            string result = "The area";
            result = result + " is " + area;
            Console.WriteLine(result);


            // A boolean variable is either true or false
            bool truthValue = true;
            Console.WriteLine(truthValue);

           

        }

        
    }
}
