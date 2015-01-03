using System;
using System.Globalization;

namespace CryptoChallenges.Set1
{
    /// <summary> 
    /// A collection of utilities for working with hex strings.
    /// </summary>
    internal static class HexString
    {
        /// <summary>
        /// Converts a hex string into it's equlivant byte values and Base64 encodes the resulting bytes.
        /// </summary>
        /// <param name="value">A string in hexidecimal format (e.g. "11AABBCCDD")</param>
        public static string Base64Encode(string value)
        {
            return Convert.ToBase64String(ToByteArray(value));
        }

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

        /// <summary>
        /// Converts the value of each element to it's hexidecimal string representation
        /// </summary>
        /// <param name="buffer">An array of bytes</param> 
        /// <returns></returns>
        public static string FromByteArray(byte[] buffer)
        {
            return BitConverter.ToString(buffer).Replace("-", "");
        }
    }
}