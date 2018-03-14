using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {

            const byte sample1 = 0x3A;
            byte sample2 = 58;
            int heartRate = 85;
            double deposits = 135002796;
            const float acceleration = (float)9.800;
            float mass = (float)14.6;
            double distance = 129.763001;
            bool lost = true;
            bool expensive = true;
            int choice = 2;
            const char integral = '\u222B';
            const String greeting = "Hello";
            String name = "Karen";

            //compare the values of sample1 and sample2
            if (sample1 == sample2)
            {
                Console.WriteLine("The samples are equal.");
            }
            else
            {
                Console.WriteLine("The samples are not equal.");
            }

            //checks heart rate for normality
            if (heartRate >= 40 && heartRate <= 80)
            {
                Console.WriteLine("Heart rate is normal.");
            }
            else
            {
                Console.WriteLine("Heart rate is not normal");
            }

            //checks deposits to assess wealth
            if (deposits >= 100000000)
            {
                Console.WriteLine("You are exceedingly wealthy.");
            }
            else
            {
                Console.WriteLine("Sorry you are so poor.");
            }

            //calculate and display the value of force
            float force = mass * acceleration;
            Console.WriteLine("force = " + force);

            //display the distance
            Console.WriteLine(distance + " is the distance.");

            //assess the states of expensive and lost
            if (lost && expensive)
            {
                Console.WriteLine("I am really sorry! I will get the manager.");
            } else if (lost)
            {
                Console.WriteLine("Here is coupon for 10% off.");
            }

            //evaluate validity of choice
            switch (choice)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("You chose " + choice + ".");
                    break;

                default:
                    Console.WriteLine("You made an unknown choice.");
                    break;
            }

            //display the integral character
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(integral + " is an integral.");

            //print values from 5 to 10 using a for loop
            for (int i = 5; i < 11; i++)
            {
                Console.WriteLine("i = " + i);
            }

            //iterate age using a while loop
            int age = 0;
            while (age < 6)
            {
                Console.WriteLine("age = " + age);
                age++;
            }

            //display name and greeting
            Console.WriteLine(greeting + " " + name);

        }
    }
}
