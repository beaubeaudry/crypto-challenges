using System;
using System.IO;

namespace CryptoChallenges.Set1.Problem1
{
    public class Solution
    {
        public static void Solve()
        {
            const string input =
               "49276d206b696c6c696e6720796f757220627261696e206c696b65206120706f69736f6e6f7573206d757368726f6f6d";

            const string expected = "SSdtIGtpbGxpbmcgeW91ciBicmFpbiBsaWtlIGEgcG9pc29ub3VzIG11c2hyb29t";

            var encoded = Convert.ToBase64String(HexString.ToByteArray(input));

            Console.WriteLine("Expected: {0}", expected);
            Console.WriteLine("Result: {0}", encoded);
        }
    }
}