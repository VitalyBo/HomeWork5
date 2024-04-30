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

/*In programming, conditions like if, else if, and else blocks are known as a "Decision Structure."

In a single if/else if/else structure, only one code block can run.

The process goes like this:

If the condition of the if statement is true, the code block associated with it will run, and the rest of the structure will be skipped.
If the if condition is false, but the condition of an else if statement is true, the code block associated with the else if will run, and the rest of the structure will be skipped.
If none of the conditions are true, the else block will run by default.

f you have two if separate statements, can these both run?

if (condition) { // first if }
if (second condition { // second if }
Yes, if you have two separate if statements, each with its own condition, both blocks of code can potentially run independently.

If condition1 is true, the code inside the first if block will run. Similarly, if condition2 is true, the code inside the second if block will run. If both conditions are true, both blocks of code will run sequentially.




How many if else if statements can you have?

In most programming languages, there is typically no strict limit on the number of else if statements you can have. You can have as many else if statements as necessary to handle various conditions in your code. This structure allows you to check multiple conditions sequentially until one of them evaluates to True. However, it's essential to consider readability and maintainability when adding numerous else if statements, as overly complex logic can become difficult to understand and debug.







Can you have an else if / else without an if?
else if (condition)  { // else if statement }
else { // else statement }

No, in most programming languages, you cannot have an else if or else statement without an if preceding it. These constructs are part of conditional statements that require an initial condition to evaluate.

For example, in languages like Python, C, Java, etc., the else if (or elif in Python) and else statements must follow an if statement.




Can you have an if without an else?
if (condition) { // if statement }

Yes, you can have an if statement without an else block.

In programming, an if statement checks a condition and executes a block of code if that condition is true. However, if the condition is false, the code simply continues executing without any special handling.




Which logical operator do you choose if you have 2 Conditions and both need to be true?

If you have two conditions and both need to be true for an overall condition to be true, you would typically use the "logical AND" operator. In most programming languages, the logical AND operator is represented by &&.

Which logical operator do you choose if you have 2 Conditions, but only one needs to be true?

If you have two conditions and only one needs to be true for an overall condition to be true, you would typically use the "logical OR" operator. In most programming languages, the logical OR operator is represented by ||.*/