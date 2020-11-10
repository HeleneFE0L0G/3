using System;
using System.Transactions;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            int speedLimit;
            int speed;
            speedLimit = 35;
            Console.WriteLine("Enter Speed");
            speed = Convert.ToInt32(Console.ReadLine());

            if (speed > speedLimit) { Console.WriteLine("SLOW NOW"); }

            bool isTrue = false;
            if (isTrue == true)
            { Console.WriteLine("It's True!"); }
            else { Console.WriteLine("It's False!"); }

            double farenheit;
            double celsius;
            Console.WriteLine("Enter Temperature");
            farenheit = Convert.ToDouble(Console.ReadLine());
            celsius = (farenheit - 32d) * (5d / 9d);
            Console.WriteLine("The temperature is: " + celsius);
            if (celsius < 40) { Console.WriteLine("It is cold!"); }


            Console.WriteLine("1 Through 10 Increments of 1");
            int i = 1;
            while (i++ <= 9)
            { Console.WriteLine(i); i++; }


            Console.WriteLine("60 Through 20 Decrements of 5");
                    int j = 60;
            while (j - 5 >= 20)
            { Console.WriteLine(j); j= j-5; }          

            Console.WriteLine("10 Through 20 Increments of 2");
            int b = 10;
            while (b <= 20)
            { Console.WriteLine(b);b = b + 2; 
            }    
        }
    }
}


//Compare and contrast the if single-selection statement and the while repetition statement.  
//How are these two statements similar?  How are they different? 
//The IF single selection statement executes a peice of code depending upon if the given condition is true or false.
//The while repetition statement executes a piece of code to repeat for as long a certain condition remains true. 

