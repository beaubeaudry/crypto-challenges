using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CryptoChallenges.Set1
{
    public static class Problem3
    {
        public static string Solve(string input)
        {
            double topScore = 0.0;
            string topString = "";

            // 
            var bytes = HexString.ToByteArray(input);
            
            // For each potential key value we XOR the input string by the
            // key, convert back to a string, and return the scored result.
            for (byte key = 0; key < 255; key++)
            {
                byte[] xoredBytes = Bitwise.XORArray(bytes, key);
                string xoredString = Encoding.ASCII.GetString(xoredBytes);
                double score = StringScorer.ScoreByLetterFrequency(xoredString);

                if (score > topScore)
                {
                    topScore = score;
                    topString = xoredString;
                }
            }

            return topString;
        }
    }
}
