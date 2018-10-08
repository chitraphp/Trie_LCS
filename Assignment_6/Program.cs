using System;

namespace Assignment_6
{
    class Program
    {
        public static int Value(char letter)
        {
            switch (letter)
            {
                case 'I':
                    return 1;                    
                case 'V':
                    return 5;
                case 'X':
                    return 10;
                case 'L':
                    return 50;
                case 'C':
                    return 100;
                case 'D':
                    return 500;
                case 'M':
                    return 1000;
                default:
                    return -1;
            }
        }
        public static int RomanToNumber(string str)
        {
            int res = 0;

            // Traverse given input
            for (int i = 0; i < str.Length; i++)
            {
                // Getting value of symbol s[i]
                int s1 = Value(str[i]);

                if (i + 1 < str.Length)
                {
                    // Getting value of symbol s[i+1]
                    int s2 = Value(str[i + 1]);

                    // Comparing both values
                    if (s1 >= s2)
                    {
                        // Value of current symbol is greater
                        // or equal to the next symbol
                        res = res + s1;
                    }
                    else
                    {
                        res = res + s2 - s1;
                        i++; // Value of current symbol is
                             // less than the next symbol
                    }
                }
                else
                {
                    res = res + s1;
                    i++;
                }
            }
            return res;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string str = "MCMIV";
            //int output = RomanToNumber(str);
            //Console.WriteLine(output);
            //Console.ReadLine();
            string s1 = "apple";
            string[] strsArray = { "april", "ape" };            
            LongestCommonPrefix lcs = new LongestCommonPrefix();
            string prefix = lcs.longestCommonPrefix(s1, strsArray);
            Console.WriteLine(prefix);
            Console.ReadLine();
        }
    }
}
