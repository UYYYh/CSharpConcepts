using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSharpConcepts.Classes.Examples.TypeExamples;

namespace CSharpConcepts.Classes.Exercises
{
    public static class TypeExercises
    {
        // Q1: Calculator 1
        // Write to the console correctly the results of: +. - , *, /
        public static void Calculator(int num1, int num2)
        {
            Console.WriteLine($"{num1}+{num2}={num1 + num2}\n{num1}*{num2}={num1 * num2}\n{num1}-{num2}={num1 - num2}\n{num1}/{num2}={num1 / num2}");
        }

        // Q2: Calculator 2
        // Try to convert both the values to a double and write to the console the results of: +. - , *, /
        public static void Calculator(string value1, string value2)
        {
            double num1 = double.Parse(value1);
            double num2 = double.Parse(value2);
            Console.WriteLine($"{num1}+{num2}={num1 + num2}\n{num1}*{num2}={num1 * num2}\n{num1}-{num2}={num1 - num2}\n{num1}/{num2}={num1 / num2}");
        }

        // Q3: Binary Strings
        // Write to the console the number printed in Binary, Decimal and Hex formats
        public static void BinaryStrings(int num)
        {
            Decimal Dec = Convert.ToDecimal(num);
            string binary = Convert.ToString(num, 2);
            string Hex = Convert.ToString(num, 16);
            Console.WriteLine($"binary:{binary}\nhexadecimal:{Hex}\ndecimal:{Dec}");
        }

        // Q4: BMI
        // Calculate and return the BMI - Body mass index
        public static double BMICalculator(double height, double weight)
        {
            double BMI = weight / (height*height) ;
            return BMI;
        }

        // Q5: FutureDate
        // Write to the console today's date. Return the date that it will be when the days passed in are added to the current date. 
        public static DateTime FutureDate(int days)
        {
            DateTime Today = DateTime.Today;
            return Today.AddDays(days);
        }
        
        // Q6: Languages
        // Using the enum below write a program that will convert the proposed language to the enum if availabe
        // Otherwise it should randomly assign a language
        public enum Language
        {
            French,
            Italian,
            Spanish,
            Finnish
        }

        public static Language SelectLanguage()
        {
            Random random = new Random();
            int choice = random.Next(0, 4);
            Language Lang = (Language)choice; // Converts the number to the house enum
            return Lang;
        }

        public static Language SelectLanguage(string proposedLanguage)
        {
            if (Enum.TryParse(proposedLanguage, out Language Lang))
            {
                return Lang;
            }
            else
            {
                Console.WriteLine("The language you entered was invalid, randomly assigning a language...");
                Lang = SelectLanguage();
                return Lang;

            }
        }


    }
}
