using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using CSharpConcepts.Classes.Exercises;

namespace CSharpConcepts
{
    internal class Exercises
    { 
        internal static void Run()
        {
            CallTypeExercises();
            CallSelectionExercises();
        }

        private static void CallTypeExercises()
        {
            // Add your calling code here for the questions an example is below
            //Tests:

            //Console.WriteLine("# Calculator");
            //TypeExercises.BinaryStrings(80);
            //Console.WriteLine(TypeExercises.BMICalculator(200, 10));
            //Console.WriteLine(TypeExercises.FutureDate(2));
            //Console.WriteLine(TypeExercises.SelectLanguage("Spanish"));
            //Console.WriteLine(SelectionExercises.FizzBuzz(9));
            //Console.WriteLine(SelectionExercises.VowelOrConsonant('p'));
            //SelectionExercises.DiceRoll();
            //Console.WriteLine(SelectionExercises.Angle(71));
            //Console.WriteLine(SelectionExercises.RPS("Rock"));
            Console.WriteLine(SelectionExercises.Triangle(90, 9, 9));
        }

        private static void CallSelectionExercises()
        {
            // Add your calling code here for the selection questions
        }
    }
}
