using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class OperatorDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter weekday number (1-7):");
            int Weekday = Convert.ToInt32(Console.ReadLine());

            switch (Weekday)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;

                default:
                    Console.WriteLine("Wrong number input");
                    break;
            }



            


            
        


            

            
            
        }
    }
}
