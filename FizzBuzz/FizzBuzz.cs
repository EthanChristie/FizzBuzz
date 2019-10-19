using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public static void Main(string[] args)
        {
            var answer = FizzBuzzSolver.Solve(100);

            foreach (var line in answer)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine();
            Console.WriteLine("Done.");
            Console.WriteLine("Press [enter] to quit");
            Console.ReadLine();
        }
    }
}
