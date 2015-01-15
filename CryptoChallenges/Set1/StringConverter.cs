using System;
using System.Text;

namespace CryptoChallenges.Set1
{
    public static class StringConverter
    {
        /// <summary>
        /// Convert from a byte array to a string.
        /// <remarks>Returns string in all upper case.</remarks>
        /// </summary>
        public static string FromBytes(byte[] bytes)
        {
            return BitConverter.ToString(bytes).Replace("-", "");
        }

        /// <summary>
        /// Convert from a string to a byte array.
        /// </summary>
        public static byte[] ToBytes(string value)
        {
            return Encoding.ASCII.GetBytes(value);
        }
    }
}
