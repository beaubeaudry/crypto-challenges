using System;
using System.Text;

namespace CryptoChallenges.Set1
{
    public class Bitwise
    {
        /// <summary>
        /// Returns the XOR combination of two buffers.
        /// </summary>
        public static byte[] XORArray(byte[] a, byte[] b)
        {
            if (a.Length != b.Length)
                throw new ArgumentException("Both arrays must be the same length");

            var result = new byte[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                result[i] = (byte) (a[i] ^ b[i]);
            }

            return result;
        }
        
        /// <summary>
        /// Returns a copy of a string XORed by a given byte.
        /// </summary>
        public static string SingleByteXOR(string value, byte key)
        {
            byte[] bytes = HexString.ToByteArray(value);
            byte[] xored = SingleByteXOR(bytes, key);
            return Encoding.ASCII.GetString(xored);
        }
        
        /// <summary>
        /// Returns a copy of an array XORed by a given byte.
        /// </summary>
        public static byte[] SingleByteXOR(byte[] array, byte b)
        {
            var result = new byte[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                result[i] = (byte)(array[i] ^ b);
            }

            return result;
        }
    }
}