using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CryptoChallengesTests
{
    [TestClass]
    public class Set1Tests
    {
        [TestMethod]
        public void Problem1_Solve()
        {
            const string input =
                "49276d206b696c6c696e6720796f757220627261696e206c696b65206120706f69736f6e6f7573206d757368726f6f6d";
            const string expected = "SSdtIGtpbGxpbmcgeW91ciBicmFpbiBsaWtlIGEgcG9pc29ub3VzIG11c2hyb29t";

            var result = CryptoChallenges.Set1.Problem1.Solve(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Problem2_Solve()
        {
            const string first = "1c0111001f010100061a024b53535009181c";
            const string second = "686974207468652062756c6c277320657965";

            const string expected = "746865206b696420646f6e277420706c6179";

            var result = CryptoChallenges.Set1.Problem2.Solve(first, second);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Problem3_Solve()
        {
            const string input = "1b37373331363f78151b7f2b783431333d78397828372d363c78373e783a393b3736";
            const string expected = "Cooking MC's like a pound of bacon";

            var result = CryptoChallenges.Set1.Problem3.Solve(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Problem4_Solve()
        {
            const string expected = "Now that the party is jumping\n";

            var result = CryptoChallenges.Set1.Problem4.Solve();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Problem5_Solve()
        {
            string input = "Burning 'em, if you ain't quick and nimble\nI go crazy when I hear a cymbal";
            string key = "ICE";
            var expected = "0b3637272a2b2e63622c2e69692a23693a2a3c6324202d623d63343c2a26226324272765272" +
                           "a282b2f20430a652e2c652a3124333a653e2b2027630c692b20283165286326302e27282f";

            var result = CryptoChallenges.Set1.Problem5.Solve(input, key).ToLower();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Problem6_Solve()
        {
            var result = CryptoChallenges.Set1.Problem6.Solve();

            Assert.Inconclusive();
        }
    }
}