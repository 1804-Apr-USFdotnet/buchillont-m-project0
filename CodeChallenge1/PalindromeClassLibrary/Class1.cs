using System;

namespace PalindromeClassLibrary
{
    public static class Class1
    {
        public static bool Palindromes(this String str1)
        {
            /* System.Text.StringBuilder sb = new System.Text.StringBuilder();
             String str2 = "";
             //str2 = String.Copy(str1);

             for(int i = 0; i < str1.Length; i++)
             {
                 str2.Append(str1[str1.Length - i);
             }*/

            //string str = "Characters in a string.";
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach (var ch in str1)
                sb.Append(" '").Append(ch).Append("' ");

            Console.WriteLine("Characters in the string:");
            Console.WriteLine("  {0}", sb);

            if(sb.Equals(str1))
            {
                return true;
            }

            return false;
        }

            /*string isPalindrome;
            string isPalindromeInEnd;

        for(int i = 0; i<isPalindrome.Length; i++)
            {
                isPalindromeInEnd[i] = isPalindrome[i];
            }

        if(isPalindromeInEnd.Equals(isPalindrome))
        {
            Console.WriteLine("This is a palindrome. ");
        }

        else
           {
                Console.WriteLine("This is not a palindrome. ");
            }*/
    }
}
