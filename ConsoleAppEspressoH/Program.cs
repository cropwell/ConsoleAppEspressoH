﻿using System;
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
                double tal1 = Convert.ToDouble(Console.ReadLine());

                
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
                double tal2 = Convert.ToDouble(Console.ReadLine());
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
                double tal3 = Convert.ToDouble(Console.ReadLine());

                
                double result2 = 0;
                
                // Först addition
                if (operator1 == '+' && operator2 == '+')
                {
                    result2 = tal1 + tal2 + tal3;
                }
                else if (operator1 == '+' && operator2 == '-')
                {
                    result2 = tal1 + tal2 + tal3;
                }
                else if (operator1 == '+' && operator2 == '*')
                {
                    result2 = tal1 + tal2 * tal3;
                }
                else if (operator1 == '+' && operator2 == '/')
                {
                    result2 = tal1 + tal2 / tal3;
                }
                // Först subtraktion
                else if (operator1 == '-' && operator2 == '+')
                {
                    result2 = tal1 - tal2 + tal3;
                }
                else if (operator1 == '-' && operator2 == '-')
                {
                    result2 = tal1 - tal2 - tal3;
                }
                else if (operator1 == '-' && operator2 == '*')
                {
                    result2 = tal1 - tal2 * tal3;
                }
                else if (operator1 == '-' && operator2 == '/')
                {
                    result2 = tal1 - tal2 / tal3;
                }
                // Först multiplikation
                else if (operator1 == '*' && operator2 == '+')
                { 
                    result2 = tal1 * tal2 + tal3;
                }
                else if (operator1 == '*' && operator2 == '-')
                {
                    result2 = tal1 * tal2 - tal3;
                }
                else if (operator1 == '*' && operator2 == '*')
                {
                    result2 = tal1 * tal2 * tal3;
                }
                else if (operator1 == '*' && operator2 == '/')
                {
                    result2 = tal1 * tal2 /tal3;
                }
                // Först division
                else if (operator1 == '/' && operator2 == '+')
                {
                    result2 = tal1 / tal2 + tal3;
                }
                else if (operator1 == '/' && operator2 == '-')
                {
                    result2 = tal1 / tal2 - tal3;
                }
                else if (operator1 == '/' && operator2 == '*')
                {
                    result2 = tal1 / tal2 * tal3;
                }
                else if (operator1 == '/' && operator2 == '/')
                {
                    result2 = tal1 / tal2 / tal3;
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
