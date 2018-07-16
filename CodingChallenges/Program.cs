using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    public class Program
    {
        /// <summary>
        ///  Week 2 Coding Challenge
        /// </summary>
        public static bool IsPalindrome(string s)
        {
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (!s[i].Equals(s[s.Length - i - 1]))
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
        }
    }
}
