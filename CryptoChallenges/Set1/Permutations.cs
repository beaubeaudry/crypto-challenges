using System.Collections.Generic;

namespace CryptoChallenges.Set1
{
        /// <summary>
        /// Utility class for generating permutations.
        /// </summary>
        public static class Permutations
        {
            /// <summary>
            /// XOR a string by each byte from 0 to 255 and return each result.
            /// </summary>
            public static IEnumerable<string> SingleByteXOR(string value)
            {
                for (byte key = 0; key < 255; key++)
                {
                    yield return Bitwise.SingleByteXOR(value, key);
                }
            }
        }
}