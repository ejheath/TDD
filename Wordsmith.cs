using System;
namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string str1)
        {
            var reverse = "";


            for (int i = str1.Length - 1; i >= 0; i--)
            {
                reverse += str1[i];
            }

            if (reverse == str1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
