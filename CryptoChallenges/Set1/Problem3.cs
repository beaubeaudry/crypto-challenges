using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace CryptoChallenges.Set1
{
    public static class Problem3
    {
        public static string Solve(string input)
        {
            var scoreResults = XORnScore(input);

            var top = scoreResults.OrderByDescending(result => result.Score).First();

            return top.Value;
        }

        private static IEnumerable<ScoreResult> XORnScore(string input)
        {
            // Assume the input is a hex string and take it's equalivent bytes.
            var bytes = HexString.ToByteArray(input);

            // For each potential key value we XOR the input string by the
            // key, convert back to a string, and return the scored result.
            for (var key = byte.MinValue; key < byte.MaxValue; key++)
            {
                byte[] xoredBytes = Bitwise.XORArray(bytes, key);
                string xoredString = Encoding.ASCII.GetString(xoredBytes);
                double score = ScoreString(xoredString);
                yield return new ScoreResult(key, xoredString, score);
            }
        }

        private struct ScoreResult
        {
            public ScoreResult(byte key, string value, double score)
            {
                Key = key;
                Value = value;
                Score = score;
            }
           
            public readonly byte Key;
            public readonly string Value;
            public readonly double Score;
        }

        public static double ScoreString(string input)
        {
            // This produces the sum of the scores for each character. Case-insensitive. 
            return input.ToLower().Where(CharacterScores.ContainsKey).Sum(c => CharacterScores[c]);
        }

        static readonly Dictionary<char, float> CharacterScores = new Dictionary<char, float>()
        {
            {' ', 5.0f},
            {'a', 8.167f},
            {'b', 1.492f},
            {'c', 2.782f},
            {'d', 4.253f},
            {'e', 12.702f},
            {'f', 2.228f},
            {'g', 2.015f},
            {'h', 6.094f},
            {'i', 6.966f},
            {'j', 0.153f},
            {'k', 0.772f},
            {'l', 4.025f},
            {'m', 2.406f},
            {'n', 6.749f},
            {'o', 7.507f},
            {'p', 1.929f},
            {'q', 0.095f},
            {'r', 5.987f},
            {'s', 6.326f},
            {'t', 9.056f},
            {'u', 2.758f},
            {'v', 0.978f},
            {'w', 2.360f},
            {'x', 0.150f},
            {'y', 1.974f},
            {'z', 0.074f}
        };
    }
}
