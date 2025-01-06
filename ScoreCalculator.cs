using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalScoreCalculator
{
    public static class ScoreCalculator
    {
        public static int CalculateScore(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                Console.WriteLine("Enter one or more numbers");
                return 0;
            }
            int score = 0;
            foreach (var number in numbers)
            {
                if (number == 8)
                {
                    score += 5;
                }
                if (number % 2 == 0)
                {
                    score += 1;
                }
                else
                {
                    score += 3;
                }
            }
            return score;
        }
    }
}
