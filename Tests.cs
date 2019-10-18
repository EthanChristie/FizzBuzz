using System;
using System.Linq;
using NUnit.Framework;

namespace FizzBuzz
{

    [TestFixture]
    public class Tests
    {
        [Test]
        public void SolveForOne()
        {
            var lines = FizzBuzzSolver.Solve(1);
            var lastLine = lines.Last();

            Assert.AreEqual("1", lastLine);
        }
        
        [Test]
        public void SolveForThree()
        {
            var answer = FizzBuzzSolver.Solve(3);
            var lastLine = answer.Last();

            Assert.AreEqual("Fizz", lastLine);
        }
        
        [Test]
        public void SolveForFive()
        {
            var lines = FizzBuzzSolver.Solve(5);
            var lastLine = lines.Last();

            Assert.AreEqual("Buzz", lastLine);
        }
    }
}