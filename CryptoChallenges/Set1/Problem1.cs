﻿using System;
using System.IO;

namespace CryptoChallenges.Set1
{
    // Convert hex to base64.
    public static class Problem1
    {
        public static string Solve(string input)
        {
            return HexString.Base64Encode(input);
        }
    }
}