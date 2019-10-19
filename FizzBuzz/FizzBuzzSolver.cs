using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzzSolver
    {
        private static readonly Dictionary<int, string> DivisorRules = new Dictionary<int, string>()
        {
            { 3, "Fizz" },
            { 5, "Buzz" }
        };

        public static List<string> Solve(int solveFor)
        {
            if (solveFor < 1)
                throw new ArgumentOutOfRangeException(nameof(solveFor), solveFor,"Must supply integer above 0");

            var answer = new List<string>();

            var counter = 1;

            while (counter <= solveFor)
            {
                var line = SolveForSingle(counter);
                answer.Add(line);
                counter++;
            }

            return answer;
        }

        private static string SolveForSingle(int solveFor)
        {
            var line = new StringBuilder();
            foreach (var divisor in DivisorRules.Keys)
            {
                if (solveFor % divisor == 0)
                {
                    line.Append(DivisorRules[divisor]);
                }
            }

            if (string.IsNullOrEmpty(line.ToString()))
            {
                line.Append(solveFor);
            }

            return line.ToString();
        }
    }
}