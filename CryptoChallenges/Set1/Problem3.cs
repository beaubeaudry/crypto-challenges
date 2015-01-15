
namespace CryptoChallenges.Set1
{
    public static class Problem3
    {
        public static string Solve(string input)
        {
            double topScore = 0.0;
            string bestResult = "";

            foreach (string permutation in Permutations.SingleByteXOR(input))
            {
                double score = StringScorer.ScoreByLetterFrequency(permutation);
                if (score > topScore)
                {
                    topScore = score;
                    bestResult = permutation;
                }
            }

            return bestResult;
        }
    }
}
