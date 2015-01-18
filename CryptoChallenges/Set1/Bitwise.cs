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

        public static byte[] RepeatingByteXOR(string value, string key)
        {
            return RepeatingByteXOR(Encoding.ASCII.GetBytes(value), Encoding.ASCII.GetBytes(key));
        }

        /// <summary>
        /// XOR each byte in the input array by each repeating byte of the key.
        /// </summary>
        public static byte[] RepeatingByteXOR(byte[] array, byte[] key)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] ^= key[i % key.Length];
            }

            return array;
        }

        /// <summary>
        /// Counts the number of set bits in an integer.
        /// </summary>
        public static int CountSetBits(int i)
        {
            // Source: http://stackoverflow.com/questions/109023/how-to-count-the-number-of-set-bits-in-a-32-bit-integer
            i = i - ((i >> 1) & 0x55555555);
            i = (i & 0x33333333) + ((i >> 2) & 0x33333333);
            return (((i + (i >> 4)) & 0x0F0F0F0F) * 0x01010101) >> 24;
        }
    }
}