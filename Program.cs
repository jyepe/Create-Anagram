using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input Strings
            String a = "dce";
            String b = "abc";
            createAnagram(a, b);
        }

        private static void createAnagram(String one, String two)
        {
            int[] lettercounts = new int[26];

            foreach (char c in one.ToCharArray())
            {
                lettercounts[c - 'a']++;
            }

            foreach (char c in two.ToCharArray())
            {
                lettercounts[c - 'a']--;
            }

            int result = 0;

            foreach (int num in lettercounts)
            {
                result += Math.Abs(num);
            }

            Debug.Write(result);
        }
    }
}
