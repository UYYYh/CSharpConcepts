using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts.Classes.Exercises
{
    public static class IterationExercises
    {
        // Q1: Centuries
        // Calculate the number of times a batter scored a century (100 runs) or more in a match
        public static int NumberOfCenturiesScored(List<int> runsScored)
        {
            int times = 0;
            foreach(int score in runsScored)
            {
                if (score >= 100)
                {
                    times += 1;
                }
            }
            return times;
        }

        // Q2: Batting Average
        // Calculate the batting average.
        // Exclude any values where the runs scored were negative as a negative value indicates that they did not bat in that match.
        public static double BattingAverage(List<int> runsScored)
        {
            double total = 0;
            double length = runsScored.Count();
            foreach(int score in runsScored)
            {
                if (score >= 0)
                {
                    total = total + score;
                }
                else
                {
                    length = length - 1;
                }
            }
            return total / length;
        }

        // Q3: User Names
        // Determine the user names
        // It will be the first three characters of their name and a number, which will be the order of the name in the list.
        public static string UserNames(List<string> names)
        {   
            List<string> users = new() {};
            int index = 0;
            foreach(string name in names)
            {
                index=index+1;
                users.Add($"{name.Substring(0,3)}{index}");
            }
            string output = string.Join(", ", users);
            return output;
        }

        // Q4: Calculate Multiples
        // Write a function that will output the multiple of a number from 1 to the max number specified
        // So called with 6 and 10 it would output [6, 12, 18, 24, 30, 36, 42, 48, 54, 50]
        public static string CalculateMultiples(int number, int maximumMultiple)
        {
            List<int> Multiples = new();
            for (int i=1; i < maximumMultiple+1; i++)
            {
                Multiples.Add(i * number);
            }
            string Output = string.Join(", ", Multiples);
            return Output;
        }

        // Q5: Is Prime
        // Write a function to determine whether a number is prime
        public static Boolean IsPrime(int num1)
        {
            Boolean Output = true;
            for (int i=2; i < num1; i++)
            {
                if (num1 % i == 0)
                {
                    Output = false;
                }
            }
            return Output;
        }


        // Q6: Star Pattern
        // Write a procedure to output a star pattern based on the number of stars input
        // So for example if the user enters 6 then it will output:

        

        public static List<string> Stars(int star)
        {
            List<string> Output = new() { };
            for (int i=0; i < star; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Output.Add("*");
                }
                Output.Add("");
            }
            for (int i = star; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Output.Add("*");
                }
                Output.Add("");
            }
            foreach (string stars in Output)
            {

            }
            return Output;
        }

        

        // Q7: This function should take a noughts and crosses board represented as an character list,
        // A space represents an empty space as shown below.

        public static char NAC(List<List<char>> board)
        {
            char Output = ' ';
            foreach (List<char> row in board)
            {
                int noughts = 0;
                int crosses = 0;
                foreach (char symbol in row)
                if (symbol == '0')
                    {
                        noughts = noughts+1;
                    }
                else if (symbol == 'X')
                    {
                        crosses = crosses+1;
                    }
                if (crosses == 3)
                {
                    Output = 'X';
                }
                else if (noughts == 3)
                {
                    Output = '0';
                }
            }

            

            for (int i=0; i<3; i++)
            {
                int crosses1 = 0;
                int noughts1 = 0;
                for (int j=0; j>=2; j++)
                {
                    if (board[j][i] == 'X')
                    {
                        crosses1=crosses1+1;
                    }
                    else if (board[j][i] == '0')
                    {
                        noughts1= noughts1+1;  
                    }
                }
                if (crosses1 == 3)
                {
                    Output = 'X';
                }
                else if (noughts1 == 3)
                {
                    Output = '0';
                }

            }
            int noughts2 = 0;
            int crosses2 = 0;
            for (int i =0; i<3; i++)
            {   
                
                if (board[i][i] == '0')
                {
                    noughts2 = noughts2 + 1;
                }
                else if (board[i][i] == 'X')
                {
                    crosses2 = crosses2 + 1;
                }
                if (noughts2 == 3)
                {
                    Output = '0';
                }
                else if (crosses2 == 3)
                {
                    Output= 'X';
                }
            }
            int noughts3 = 0;
            int crosses3 = 0;

            for (int i = 0; i < 3; i++)
            {
                
                if (board[i][2-i] == '0')
                {
                    noughts3 = noughts3 + 1;
                }
                else if (board[i][2-i] == 'X')
                {
                    crosses3 = crosses3 + 1;
                }
                if (noughts3 == 3)
                {
                    Output = '0';
                }
                else if (crosses3 == 3)
                {
                    Output = 'X';
                }
            }


            return Output;
            
        }

       /* List<List<char>> board = new()
        {
            new() { 'X', '0', 'X' },
            new() { ' ', '0', ' ' },
            new() { 'X', '0', ' ' }
        };*/

        // The function should return a char: 'X' if player X has won, '0' if the player 0 has won,
        // and ' ' if there is currently no winner.
    }
}
