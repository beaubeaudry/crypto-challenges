
using System.Collections.Generic;

namespace CryptoChallenges.Set1
{
    // Single-byte XOR cipher.
    public static class Problem3
    {
        public static string Solve(string input)
        {
            double topScore = 0.0;
            string bestResult = "";

            foreach (string permutation in SingleByteXOR(input))
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

        // XOR a string by each byte from 0 to 255 and return each result.
        private static IEnumerable<string> SingleByteXOR(string value)
        {
            for (byte key = 0; key < 255; key++)
            {
                yield return Bitwise.SingleByteXOR(value, key);
            }
        }
    }
}