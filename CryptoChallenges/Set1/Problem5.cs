using System;

namespace CryptoChallenges.Set1
{
    public static class Problem5
    {
        public static string Solve(string input, string key)
        {
            var encoded = Bitwise.RepeatingByteXOR(input, key);

            return ByteArrayToString(encoded);
        }

        public static string ByteArrayToString(byte[] ba)
        {
            string hex = BitConverter.ToString(ba);
            return hex.Replace("-", "");
        }
    }
}