using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeClassLibrary;

namespace UnitTestProjectPalindrome
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange, act, assert
            string String1 = "racecar";
            //string String2 = "";

            /*for(int i = 0; i <= String1.Length; i++)
            {
                String2[i].Add(String1[i]);
            }*/
            //str2 = String.Copy(str1);
            // String2 = String.Copy(String1);

            Palindromes(String1);       //expected value is true

            /*if (String2.Equals(String1))
            {
                Console.WriteLine("{0} is a palindrome. ", String1);
            }*/

            if(Palindromes(String1).Equals)
        }
    }
}
