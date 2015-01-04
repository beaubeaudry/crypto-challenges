﻿using System;

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
        /// Returns a copy of the array XORed by the given byte.
        /// </summary>
        public static byte[] XORArray(byte[] array, byte b)
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