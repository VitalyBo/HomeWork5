// See husing System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace Сonsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            int choice = 0;
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Hello choose what you will do)\n");
                Console.WriteLine("1. Altitude checker\r\n2. Grade Calculator\n3. Exit\n");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                choice = int.Parse(Console.ReadLine());
                Console.ResetColor();

                if (choice == 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("1. Altitude checker\n");
                    double altitude = 0, imperial_dimens = 0;
                    while (true)
                    {
                        try
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Enter your current altitude in feet: ");
                            altitude = Double.Parse(Console.ReadLine());
                            imperial_dimens = altitude * 0.3048;
                            if (imperial_dimens >= 305 && imperial_dimens <= 1524)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"Your current altitude is {altitude} feet ({imperial_dimens} meters))");
                                Console.WriteLine("Low Altitude\r\nThis altitude is used for takeoff and landing\n");
                                Console.ResetColor();
                                continue;
                            }
                            if (imperial_dimens >= 1524 && imperial_dimens <= 7620)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"Your current altitude is {altitude} feet ({imperial_dimens} meters))");
                                Console.WriteLine("Medium Altitude\r\nThis is considered a Good Altitude for a plane to fly at.\n");
                                Console.ResetColor();
                                continue;
                            }
                            if (imperial_dimens >= 7621)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                Console.WriteLine($"Your current altitude is {altitude} feet ({imperial_dimens} meters))"); ;
                                Console.WriteLine("High Altitude\r\nThis altitude is for long-range, high-speed flights\n");
                                Console.ResetColor();
                                continue;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("It looks like you crashed the plane with all the passengers on board!!!\n");
                                Console.ResetColor();
                                break;
                            }
                        }
                        catch
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("It looks like you crashed the plane with all the passengers on board!!!\n");
                            Console.ResetColor();
                            break;
                        }
                    }

                }
                if (choice == 2)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("2. Grade Calculator\n");
                    double grade = 0;
                    while (true)
                    {
                        try
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Enter your numerical grade: ");
                            grade = Double.Parse(Console.ReadLine());

                            if (grade >= 90 && grade < 100)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"Your letter grade is: A)");
                                Console.ResetColor();
                                continue;
                            }
                            if (grade >= 80 && grade <= 90)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"Your letter grade is: B)");
                                Console.ResetColor();
                                continue;
                            }
                            if (grade >= 70 && grade <= 80)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"Your letter grade is: C)");
                                Console.ResetColor();
                                continue;
                            }

                            if (grade >= 60 && grade <= 70)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"Your letter grade is: D)");
                                Console.ResetColor();
                                continue;
                            }
                            if (grade < 60)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"Your letter grade is: F)");
                                Console.ResetColor();
                                continue;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Grade is greater than 100 is invalid!!!\n");
                                Console.ResetColor();
                                break;
                            }
                        }
                        catch
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("It seems like something going wrong!!!\n");
                            Console.ResetColor();
                            break;
                        }
                    }

                    if (choice == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Thank you so much for using our special software!\n");
                        Console.ResetColor();
                        break;
                    }
                }
            }
        }
    }
}