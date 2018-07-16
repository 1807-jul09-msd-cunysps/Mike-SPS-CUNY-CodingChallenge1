using System;
using Xunit;
using CodingChallenges;

namespace XUnitTestProject1
{
    /// <summary>
    ///  Week 2 Coding Challenge
    /// </summary>
    public class WeekTwoUnitTest
    {
        [Theory]
        [InlineData("")]
        [InlineData("a")]
        [InlineData("aa")]
        [InlineData("aaa")]
        [InlineData("abcba")]
        [InlineData("aabbccbbaa")]
        [InlineData("A nut for a jar of tuna")]
        [InlineData("Borrow or rob")]
        [InlineData("343")]
        public void TestTrue(string input)
        {
            Assert.True(Program.IsPalindrome(input));
        }

        [Theory]
        [InlineData("ab")]
        [InlineData("abc")]
        [InlineData("abcd")]
        [InlineData("js")]
        public void TestFalse(string input)
        {
            Assert.False(Program.IsPalindrome(input));
        }
    }
}
