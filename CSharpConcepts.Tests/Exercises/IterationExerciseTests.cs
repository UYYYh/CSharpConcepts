using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSharpConcepts.Classes.Exercises;
using System.Collections.Generic;
using System;

namespace CSharpConcepts.Tests.Exercises
{
    [TestClass]
    public class IterationExerciseTests
    {

        [TestMethod]
        public void TestNumberOfCenturies()
        {
            List<int> input = new() { 12, 5, -1, 100, 11, 22, 55, 17, 23, -1, 66, 100, 6, 100, 0 };
            int numCenturies = IterationExercises.NumberOfCenturiesScored(input);
            Assert.AreEqual(3, numCenturies);
        }

        [TestMethod]
        public void TestBattingAverage()
        {
            List<int> input = new() { 12, 5, -1, 100, 11, 22, 55, 17, 23, -1, 66, 100, 6, 100, 0 };
            double battingAverage = IterationExercises.BattingAverage(input);
            Assert.AreEqual(39.76923076923077, battingAverage, 0.001);
        }

        [TestMethod]
        public void TestUserNames()
        {
            List<string> Names = new() { "Bob", "Alice", "Reginald", "Will" };
            string Usernames = IterationExercises.UserNames(Names);
            Assert.AreEqual("Bob1, Ali2, Reg3, Wil4", Usernames);
        }

        [TestMethod]
        public void TestCalculatedMultiples()
        {
            string Multiples = IterationExercises.CalculateMultiples(6, 10);
            Assert.AreEqual("6, 12, 18, 24, 30, 36, 42, 48, 54, 60", Multiples);
        }

        [TestMethod]
        public void TestIsPrime()
        {
            Boolean Prime = IterationExercises.IsPrime(97);
            Assert.AreEqual(true, Prime);
        }

    }
}
