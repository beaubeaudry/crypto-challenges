using System;
using System.Globalization;

namespace CryptoChallenges.Set1.Problem1
{
    public class Solution
    {
        public static void Solve()
        {
        }
    }

    /// <summary> 
    /// A collection of utilities for working with hex strings.
    /// </summary>
    public static class HexString
    {
        /// <summary> Returns a byte array from a hex string.</summary>
        /// <param name="value">A string in hexidecimal format (e.g. "11AABBCCDD")</param>
        public static byte[] ToByteArray(string value)
        {
            // We read two characters at a time so we must have an even
            // number of bytes.
            if (value.Length % 2 != 0)
                throw new FormatException("Hex string is expected to have an even number of characters");

            byte[] result = new byte[value.Length / 2];

            // Read two characters at a time converting them into bytes.
            for (int i = 0; i < result.Length; i++)
            {
                string byteValue = value.Substring(i * 2, 2);
                result[i] = Byte.Parse(byteValue, NumberStyles.HexNumber);
            }

            return result;
        }
    }
}