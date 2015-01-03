using System;
using CryptoChallenges.Set1;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CryptoChallengesTests
{
    [TestClass]
    public class Set1Tests
    {
        [TestMethod]
        public void Problem1_Solve_ResultMatchesExpected()
        {
            const string input = "49276d206b696c6c696e6720796f757220627261696e206c696b65206120706f69736f6e6f7573206d757368726f6f6d";
            const string expected = "SSdtIGtpbGxpbmcgeW91ciBicmFpbiBsaWtlIGEgcG9pc29ub3VzIG11c2hyb29t";

            var result = CryptoChallenges.Set1.Problem1.Solve(input);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Problem2_Solve_ResultMatchesExpected()
        {
            const string first = "1c0111001f010100061a024b53535009181c";
            const string second = "686974207468652062756c6c277320657965";

            const string expected = "746865206b696420646f6e277420706c6179";

            var result = CryptoChallenges.Set1.Problem2.Solve(first, second);

            Assert.AreEqual(expected, result);
        }
    }
}