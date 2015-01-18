using System;

namespace CryptoChallenges.Set1
{
    // Fixed XOR: Write a function that takes two equal-length buffers and produces their XOR combination.
    public static class Problem2
    {
        public static string Solve(string first, string second)
        {
            var firstBytes = HexString.ToByteArray(first);
            var secondBytes = HexString.ToByteArray(second);

            var xored = Bitwise.XORArray(firstBytes, secondBytes);

            return StringConverter.FromBytes(xored).ToLower();
        }
    }
}