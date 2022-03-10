using System;
using Xunit;
using PalindromeExercise;

namespace UnitTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("kayak", true)]
        [InlineData("civic", true)]
        [InlineData("roller", false)]

        public void IsAPalindrome(string str1, bool expected)
        {
            //arrange
            var test1 = new WordSmith();
            //act
            bool actual = test1.IsAPalindrome(str1);
            //assert
            Assert.Equal(expected, actual);
        }
    }
}
