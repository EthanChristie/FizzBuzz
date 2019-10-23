using System;
using System.Linq;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public const int DefaultNumberToSolveFor = 100;
        public static void Main(string[] args)
        {
            var numberToSolveFor = CalculateNumberToSolveFor(args);

            var answer = FizzBuzzSolver.Solve(numberToSolveFor);

            foreach (var line in answer)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine();
            Console.WriteLine("Done.");
            Console.WriteLine("Press [enter] to quit");
            Console.ReadLine();
        }

        private static int CalculateNumberToSolveFor(string[] args)
        {
            if (!args.Any())
                return DefaultNumberToSolveFor;

            if (!int.TryParse(args[0], out var parsedResult))
                return DefaultNumberToSolveFor;

            return parsedResult;
        }
    }
}
