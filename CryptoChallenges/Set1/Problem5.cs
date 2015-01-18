using System;

namespace CryptoChallenges.Set1
{
    //Implement repeating-key XOR.
    public static class Problem5
    {
        public static string Solve(string input, string key)
        {
            var encoded = Bitwise.RepeatingByteXOR(input, key);

            return StringConverter.FromBytes(encoded);
        }
    }
}