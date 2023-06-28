using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempaturesAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal userDailyTemps;
            decimal sumTemps = 0;
            int numOfValidTemps = 0;
            decimal averageTemps = 0;

            Console.WriteLine("SUM&AVERAGE TEMPS\n enter '999' to quit.");

            // Ask user for temps (Fahrenheit) and validate input falls within a range
            Console.Write("Please enter a tempature (Fahrenheit): ");
            userDailyTemps = Convert.ToDecimal(Console.ReadLine());

            while(userDailyTemps != 999) // 999 is the sentinal value
            {
                // validate input is within range of -20 degrees F and 130 degrees F
                while(userDailyTemps < -20 || userDailyTemps > 130 && userDailyTemps != 999)
                {
                    Console.WriteLine("Sorry, that is an invalid tempature.");
                    Console.Write("Please enter a valid tempature (Fahrenheit): ");
                    userDailyTemps = Convert.ToDecimal(Console.ReadLine());
                }

                // Breaks outter loop (If inner loop breaks because of 999 then outter loop will break as well).
                if (userDailyTemps == 999)
                    break;

                numOfValidTemps++; // adds +1 to valid entries for use of finding average later.
                sumTemps = sumTemps + userDailyTemps; // simply adds user input to the sum.
                Console.Write("Please enter a tempature (Fahrenheit): ");
                userDailyTemps = Convert.ToDecimal(Console.ReadLine());
            }
            // Calculate average of all valid temps entered
            averageTemps = sumTemps / numOfValidTemps;

            // Display the results
            // I prob should have set the decimal precsion to hundredth
            Console.WriteLine("****************************************");
            Console.WriteLine("Total count of valid entries is: {0}", numOfValidTemps.ToString());
            Console.WriteLine("The SUM of entered temps = {0}", sumTemps.ToString());
            Console.WriteLine("The AVERAGE tempature in Fahrenheit = {0}", averageTemps.ToString("F2"));
            Console.WriteLine("*****************************************");
            Console.ReadLine();
        }
    }
}
