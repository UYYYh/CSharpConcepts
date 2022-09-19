using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;


namespace CSharpConcepts.Classes.Exercises
{
    public static class SelectionExercises
    {
        // Q1: FizzBuzz
        // Return Fizz if divisible by 3. Buzz if divisible by 5. FizzBuzz if divisible by both.
        // If divisible by neither return the number itself (as a string)
        public static string FizzBuzz(int num)
        {
            if (num % 15 == 0)
            {
                return "FizzBuzz";
            }
            else if (num % 5 == 0)
            {
                return "Buzz";
            }
            else if (num % 3 == 0)
            {
                return "Fizz";
            }
            else
            { 
                return $"{num}";
            }
        }

        // Q2: Vowel or Consonant
        // Using a switch statement write a function which returns true if the input is a vowel and
        // false if it is a consonant
        public static bool VowelOrConsonant(char letter)
        {
            Boolean result = false;            
            switch (letter) {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    result = true;
                    break;



            }
            return result;
        }

        // Q3: DiceRoller
        // Write a procedure which rolls three dice and write the following messages to the console
        // If all three dice have the same value write, "Three of a kind"
        // If two of the dice have the same value write, "You have a pair!
        // Otherwise write, "Sorry you lose
        public static void DiceRoll()
        {
            
            Random random = new Random();
            int roll1 = random.Next(1, 6);
            int roll2 = random.Next(1, 6);
            int roll3 = random.Next(1, 6);
            Console.WriteLine($"{roll1},{roll2},{roll3}");
            string message = "";
            if (roll1 == roll2 && roll1 == roll3)
            {
                message = "Three of a Kind";
            }
            else if (roll1 == roll3 || roll2 == roll3 || roll1 == roll2)
            {
                message = "You have a pair";
            }
            else
            {
                message = "Sorry you lose";
            }
            Console.WriteLine(message);
            
        }

        // Q4: Angles
        // Write a function to return whether the angle input is acute, right angle, obtuse, straight or reflex
        // Use an enum for the different angle types

        public static string Angle(int angle)
        {
            string AngleType = "null";
            if (angle < 90)
            {
                AngleType = "acute";
            }
            else if (angle == 90)
            {
                AngleType = "Right";
            }
            else if (angle < 180)
            {
                AngleType = "Obtuse";
            }
            else if (angle == 180)
            {
                AngleType = "Straight";
            }
            else if (angle < 360)
            {
                AngleType = "Reflex";
            }
            return AngleType;

        }

        // Q5: Rock, Paper Scissors
        // Write a procedure which takes the user's choice as input and randomly generate the computer's choice
        // It should write the computer's choice to the console and write whether the user lost, won, or drew.
        // Handle the user input in the calling code in Program.cs

        public static string RPS(string choice)
        {
            string[] choices = new string[] { "Rock", "Paper", "Scissors" };
            Random rand = new Random();
            string ComputerChoice = choices[rand.Next(0, 3)];
            //string ComputerChoice = choices[2];
            int ComputerIndex = Array.FindIndex(choices, choices => choices.Contains(ComputerChoice));
            int PlayerIndex = Array.FindIndex(choices, choices => choices.Contains(choice));
            Console.WriteLine($"Computer Chose:{ComputerChoice}\nYou Chose:{choice}");
            if (ComputerIndex+1 == PlayerIndex || ComputerIndex-2 == PlayerIndex) 
            {
                return "You win!";
            }
            else if (ComputerIndex-1 == PlayerIndex || ComputerIndex+2 == PlayerIndex)
            {
                return "You lose!";
            }
            else
            {
                return "Draw!";
            }
            


        } 

        // Q6: Triangle
        // Write a function that takes in three side lengths.
        // Determine whether a triangle with those sides is equilateral, isosceles, scalene or impossible

        public static string Triangle(int a,int b,int c )
        {
            if (a == b && b == c)
            {
                return "Equilateral";
            }
            else if ((a == b | a == c) | b == c)
            {
                return "Isoceles";
            }
            else if ((a + b <= c) || (a + c <= b) || (b + c <= a))
            {
                return "Impossible";
            }
            else
            {
                return "Scalene";
            }
        }
    }
}
