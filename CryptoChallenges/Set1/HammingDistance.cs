using System;

namespace CryptoChallenges.Set1
{
    public static class HammingDistance
    {
        /// <summary>
        /// Compute the number of differing bits between two strings.
        /// </summary>
        public static int Find(string first, string second)
        {
            return Find(StringConverter.ToBytes(first), StringConverter.ToBytes(second));
        }

        /// <summary>
        /// Compute the number of differing bits between two byte arrays.
        /// </summary>
        public static int Find(byte[] first, byte[] second)
        {
            if (first.Length != second.Length)
                throw new ArgumentException("Inputs must be of equal length");

            int count = 0;

            for (int i = 0; i < first.Length; i++)
            {
                count += Find(first[i], second[i]);
            }

            return count;
        }

        /// <summary>
        /// Compute the number of differing bits between two bytes.
        /// </summary>
        public static int Find(byte first, byte second)
        {
            int xored = first ^ second;
            return Bitwise.CountSetBits(xored);
        }
    }
}
