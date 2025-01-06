namespace TotalScoreCalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Example input array
            int[] firstExample = {1,2,3,4,5};
            int[] secondExample = {15, 25, 35};
            int[] thirdExample = {8,8};

            int firstTotalScore = ScoreCalculator.CalculateScore(firstExample);
            int secondTotalScore = ScoreCalculator.CalculateScore(secondExample);
            int thirdTotalScore = ScoreCalculator.CalculateScore(thirdExample);
            Console.WriteLine($"The total score for the first input array ({string.Join(", ", firstExample)}) is: {firstTotalScore}");
            Console.WriteLine($"The total score for the second input array ({string.Join(", ", secondExample)}) is: {secondTotalScore}");
            Console.WriteLine($"The total score for the third input array ({string.Join(", ", thirdExample)}) is: {thirdTotalScore}");
        }
    }
}