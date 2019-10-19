using System.Linq;
using NUnit.Framework;

namespace FizzBuzz.QualityAssurance
{

    [TestFixture]
    public class Tests
    {
        [TestCase(1, "1")]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        public void TestLastLine(int solveFor, string expectedLastLine)
        {
            var lines = FizzBuzzSolver.Solve(solveFor);

            Assert.AreEqual(expectedLastLine, lines.Last());
            Assert.AreEqual(lines.Count, solveFor);
        }

        [Test]
        public void TestFirstFifteenLines()
        {
            var firstFifteenLines = new[]
            {
                "1",
                "2",
                "Fizz",
                "4",
                "Buzz",
                "Fizz",
                "7",
                "8",
                "Fizz",
                "Buzz",
                "11",
                "Fizz",
                "13",
                "14",
                "FizzBuzz"
            };

            var actualLines = FizzBuzzSolver.Solve(15);

            var counter = 0;
            foreach (var line in firstFifteenLines)
            {
                Assert.AreEqual(line, actualLines[counter]);
                counter++;
            }

            Assert.AreEqual(15, actualLines.Count);
        }
    }
}