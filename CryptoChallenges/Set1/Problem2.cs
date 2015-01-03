using System;

namespace CryptoChallenges.Set1
{
    public static class Problem2
    {
        public static string Solve(string first, string second)
        {
            var firstBytes = HexString.ToByteArray(first);
            var secondBytes = HexString.ToByteArray(second);

            var xored = Bitwise.XORArray(firstBytes, secondBytes);

            return HexString.FromByteArray(xored);
        }
    }
}