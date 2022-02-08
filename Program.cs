using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

// <summary>
// Project 3001: Concentration Finder App
// This is a concentration calculator for console applications. The goal is to gain inputs from users, and complete the necessary calculations.
// </summary>

namespace ConcentrationFinderApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int selection;
            double massVal = 0;
            string selectedUnit;
            string[] acceptedMUnits = { "ug", "mg", "g", "kg", "lb" };

            Console.WriteLine("***********************************************");
            Console.WriteLine("\tConcentrationFinder Version 1");
            Console.WriteLine("***********************************************");
            do
            {
                Console.WriteLine("Please view the options below, and select an option\n\n");
                Console.WriteLine("1. Calculate concentration (know mass + volume)");
                Console.WriteLine("2. Calculate volume Needed (know concentration + mass)");
                Console.WriteLine("3. Calculate mass needed (know concentration + volume)");
                Console.WriteLine("4. Exit application");

                selection = Convert.ToInt32(Console.ReadLine());

                switch (selection)
                {
                    // This case calculated the concentration, given the user knows the mass and volume
                    case 1:
                        do
                        {
                            Console.WriteLine("Please enter a unit of mass from the following list: ug, mg, g, kg, lb");
                            selectedUnit = Console.ReadLine();
                            if (!acceptedMUnits.Contains(selectedUnit))
                            {
                                Console.WriteLine("Invalid entry. Please try again");
                            }

                        } while (!acceptedMUnits.Contains(selectedUnit));

                        Console.WriteLine("Please enter the value of mass");
                        massVal = Convert.ToDouble(Console.ReadLine());
                        functions.Convert(selectedUnit, ref massVal);

                        Console.WriteLine(massVal + " mg");

                        break;
                    // This case calculated the volume, given the user knows the mass and concentration
                    case 2:
                        Console.WriteLine();
                        break;
                    // This case calculated the mass, given the user knows the volume and concentration
                    case 3:
                        Console.WriteLine();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Oops, that was not a valid selection. Please try again.");
                        break;
                }
            } while (selection != 4);
            
        }
        
    }
}