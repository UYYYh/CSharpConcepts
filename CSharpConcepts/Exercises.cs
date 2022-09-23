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
            //Console.WriteLine(SelectionExercises.Triangle(90, 9, 9));
            
        }

        private static void CallSelectionExercises()
        {
            // Add your calling code here for the selection questions

            //List<string> Users = new() {"Kevin", "Tony", "Rahul"};
            //Console.WriteLine(IterationExercises.UserNames(Users));
            //List<int> ints = new() { 1, 2, 3, 4, 5 , -2};
            //Console.WriteLine(IterationExercises.BattingAverage(ints));
            //Console.WriteLine(IterationExercises.CalculateMultiples(10, 9));
            //Console.WriteLine(IterationExercises.IsPrime(434));
            //IterationExercises.Stars(6);
            //List<List<char>> board = new()
            //{
            //new() { 'X', '0', 'X' },
            //new() { '0', 'X', '0' },
            //new() { 'X', '0', '0' }
            //};
            //Console.WriteLine(IterationExercises.NAC(board));
        }
    }
}
