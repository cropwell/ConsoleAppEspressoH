using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleAppEspressoH
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nu ska vi räkna!");
            char restart = 'y';
            while (true)
            {
                Console.Write("\nMata in första talet: ");
                string tal1 = Console.ReadLine();

                
                Console.Write("Mata in första operatorn (/, *, +, -): ");
                char operator1 = Console.ReadKey().KeyChar;

                while (operator1 != '+' || operator1 != '-' | operator1 != '*' || operator1 != '/')
                {

                    if (operator1 == '+' || operator1 == '-' | operator1 == '*' || operator1 == '/')
                    {
                        break;
                    }
                    else
                    {
                       Console.Write("\n\nDu benhöver mata in ett korrekt tecken (+, -, *, /): ");
                        char op1 = Console.ReadKey().KeyChar;
                        operator1 = op1;
                    }
                }
                

                Console.Write("\nMata in ett andra tal: ");
                string tal2 = Console.ReadLine();
                Console.Write("Mata in den andra operatorn (/, *, +, -): ");

                char operator2 = Console.ReadKey().KeyChar;
                while (operator2 != '+' || operator2 != '-' | operator2 != '*' || operator2 != '/')
                {

                    if (operator2 == '+' || operator2 == '-' | operator2 == '*' || operator2 == '/')
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("\n\nDu behöver mata in ett korrekt tecken (+, -, *, /): ");
                        char op2 = Console.ReadKey().KeyChar;
                        operator2 = op2;
                    }
                }
                Console.Write("\nMata in det tredje talet: ");
                string tal3 = Console.ReadLine();

                double i1 = Convert.ToDouble(tal1);
                double i2 = Convert.ToDouble(tal2);
                double i3 = Convert.ToDouble(tal3);

                double result1 = 0;
                double result2 = 0;
                

                // Första Uträkning
                if (operator1 == '+')
                {
                    result1 = i1 + i2;
                }
                else if (operator1 == '-')
                {
                    result1 = i1 - i2;
                }
                else if (operator1 == '/')
                {
                    result1 = i1 / i2;
                }
                else
                {
                    result1 = i1 * i2;
                }

                // Andra uträkningen
                if (operator2 == '+')
                {
                    result2 = result1 + i3;
                }
                else if (operator2 == '-')
                {
                    result2 = result1 - i3;
                }
                else if (operator2 == '/')
                {
                    result2 = result1 / i3;
                }
                else
                {
                    result2 = result1 * i3;
                }

                string equation = (tal1 + " " + operator1 + " " + tal2 + " " + operator2 + " " + tal3 + " = " + result2);
                Console.WriteLine(equation);

                Console.WriteLine("\nVill du räkna igen? (y/n)");
                restart = Console.ReadKey().KeyChar;
                if (restart == 'n')
                {
                    Environment.Exit(0);
                }

            }
        }    
    }
}
