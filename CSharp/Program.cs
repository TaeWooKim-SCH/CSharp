﻿namespace CSharp
{
    internal class Program {
        static void Main(string[] args) {
            string name = "Harry Potter";

            // 1. 찾기
            bool found = name.Contains("Harry");
            int index = name.IndexOf('z'); // -1

            // 2. 변형
            name = name + " Junior";

            string lowerCase = name.ToLower();
            string upperCase = name.ToUpper();
            string newName = name.Replace('r', 'l');

            // 3. 분할
            string[] names = name.Split(new char[] { ' ' });
            string substringName = name.Substring(5);
        }
    }
}
