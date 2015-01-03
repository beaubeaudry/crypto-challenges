using CryptoChallenges.Set1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CryptoChallengesTests.HexStringTests
{
    [TestClass]
    public class HexStringTests
    {
        [TestMethod]
        public void Base64Encode_HexString_ExpectEncodedString()
        {
            const string input = "000000";
            const string expected = "AAAA";

            string result = HexString.Base64Encode(input);

            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void ToByteArray_EmptyString_ExpectEmptyArray()
        {
            string input = String.Empty;
            byte[] expected = new byte[0];

            byte[] result = HexString.ToByteArray(input);

            CollectionAssert.AreEquivalent(result, expected);
        }

        [TestMethod]
        public void ToByteArray_TwoCharacters_ExpectOneByte()
        {
            const string input = "11";
            byte[] expected = { 0x11 };

            byte[] result = HexString.ToByteArray(input);
            
            CollectionAssert.AreEquivalent(result, expected);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void ToByteArray_OddNumCharacters_ExpectException()
        {
            const string input = "111";
            byte[] result = HexString.ToByteArray(input);
        }

        [TestMethod]
        public void FromByteArray_EmptyArray_ExpectEmptyString()
        {
            byte[] input = new byte[0];

            string result = HexString.FromByteArray(input);

            Assert.AreEqual(result, "");
        }

        [TestMethod]
        public void FromByteArray_EvenCharacters_ExpectMatchingString()
        {
            byte[] input = {0x11, 0x22};

            string result = HexString.FromByteArray(input);

            Assert.AreEqual(result, "1122");
        }
    }
}
