using CryptoChallenges.Set1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CryptoChallengesTests
{
    [TestClass]
    public class BitwiseTests
    {
        [TestMethod]
        public void XORArray_SingleByte()
        {
            byte[] first = {0x11};
            byte[] second = {0x11};
            byte[] expected = {0x00};

            var result = Bitwise.XORArray(first, second);

            CollectionAssert.AreEquivalent(expected, result);
        }

        [TestMethod]
        public void XORArray_ThreeBytes()
        {
            // XOR result of hex 11 and 44 is 55
            byte[] first = { 0x11, 0x11, 0x11 };
            byte[] second = { 0x11, 0x11, 0x44 };
            byte[] expected = { 0x00, 0x00, 0x55 };

            var result = Bitwise.XORArray(first, second);

            CollectionAssert.AreEquivalent(expected, result);
        }
    }
}