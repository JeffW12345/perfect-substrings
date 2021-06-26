namespace CodingChallenges
{
    using System;
    using System.Collections.Generic;

    class Solution
    {
        // Returns the number of perfect substrings of repeating character value 'num'.
        public static int PerfectSubstring(string str, int num)
        {
            int count = 0;
            for (int startOfSliceIndex = 0; startOfSliceIndex < str.Length - 1; startOfSliceIndex++)
            {
                for (int endofSliceIndex = startOfSliceIndex + 1; endofSliceIndex < str.Length; endofSliceIndex++)
                {
                    Dictionary<char, int> dict = new Dictionary<char, int>();
                    string slice = str.Substring(startOfSliceIndex, (endofSliceIndex - startOfSliceIndex) + 1);
                    for (int i = 0; i < slice.Length; i++)
                    {
                        if (dict.ContainsKey(slice[i]))
                        {
                            dict[slice[i]]++;
                        }
                        else
                        {
                            dict[slice[i]] = 1;
                        }
                    }
                    bool isPerfect = true;
                    foreach (var entry in dict)
                    {
                        if (entry.Value != num)
                        {
                            isPerfect = false;
                        }
                    }
                    if (isPerfect)
                    {
                        Console.WriteLine(slice);
                        count++;
                    }
                }
            }
            if (count == 1)
            {
                Console.WriteLine(count + " perfect substring.");
            }
            else
            {
                Console.WriteLine(count + " perfect substrings.");
            }
            return count;
        }


        public static void Main(string[] args)
        {
            string test = "1102021222";
            PerfectSubstring(test, 2);
        }
    }
}
