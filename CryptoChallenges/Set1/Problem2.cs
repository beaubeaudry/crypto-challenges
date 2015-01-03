using System;

namespace CryptoChallenges.Set1
{
    public static class Problem2
    {
        public static void Solve()
        {
            var first = HexString.ToByteArray("1c0111001f010100061a024b53535009181c");
            var second = HexString.ToByteArray("686974207468652062756c6c277320657965");

            var xored = Bitwise.XORArray(first, second);

            Console.WriteLine("Expected: {0}", "746865206b696420646f6e277420706c6179");
            Console.WriteLine("Result: {0}", HexString.FromByteArray(xored));
        }
    }
}