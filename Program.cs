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
            double volVal = 0;
            double concVal = 0;
            string selectedUnit;
            string[] acceptedMUnits = { "ug", "mg", "g", "kg", "lb" };
            string[] acceptedVUnits = { "mL", "L", "m^3", "cm^3", "G" };

            Console.WriteLine("***********************************************");
            Console.WriteLine("\tConcentrationFinder Version 1");
            Console.WriteLine("\tNote: assuming no input/output");
            Console.WriteLine("***********************************************");
            do
            {
                Console.WriteLine("Please view the options below, and select an option\n\n");
                Console.WriteLine("1. Calculate concentration (know mass + volume)");
                Console.WriteLine("2. Calculate volume Needed (know concentration + mass)");
                Console.WriteLine("3. Calculate mass needed (know concentration + volume)");
                Console.WriteLine("0. Exit application");

                selection = Convert.ToInt32(Console.ReadLine());

                switch (selection)
                {
                    // This case calculated the concentration, given the user knows the mass and volume
                    case 1:
                        // This do-whle loop looks at the units of mass
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
                        functions.Convertm(selectedUnit, ref massVal);

                        Console.WriteLine(massVal + " mg");

                        // This do-while loop looks at the units of volume
                        do
                        {
                            Console.WriteLine("Please enter a unit of volume from the following list, assuming using H2O: mL, L, m^3, cm^3, G");
                            selectedUnit = Console.ReadLine();
                            if (!acceptedVUnits.Contains(selectedUnit))
                            {
                                Console.WriteLine("Invalid entry. Please try again");
                            }

                        } while (!acceptedVUnits.Contains(selectedUnit));

                        Console.WriteLine("Please enter the value of volume");
                        volVal = Convert.ToDouble(Console.ReadLine());
                        functions.Convertv(selectedUnit, ref volVal);

                        Console.WriteLine(volVal + " L");

                        concVal = massVal / volVal;
                        Console.WriteLine(concVal + " mg/L (ppm)");

                        break;
                    // This case calculated the volume, given the user knows the mass and concentration
                    case 2:
                        Console.WriteLine();
                        break;
                    // This case calculated the mass, given the user knows the volume and concentration
                    case 3:
                        Console.WriteLine();
                        break;
                    // This will be the exit case. This causes the program to exit.
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Oops, that was not a valid selection. Please try again.");
                        break;
                }
            } while (selection != 4);
            
        }
        
    }
}