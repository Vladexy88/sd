using System;
using System.Linq;

namespace PalindromeApp
{
    class Program
    {
        public static void CheckPalindrom()
        {
       

            string word = "";
            Console.Write("Введите слово : ");
            word = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(word))
            {
                return;
            }
            var s = word.ToCharArray().Reverse();
            string testWord = "";
            foreach (var item in s)
            {
                testWord += item;
            }
            if (testWord == word)
            {
                Console.WriteLine("Палиндром");
            }
            else
            {
                Console.WriteLine("Не палиндром");
            }
        }

        static void Main(string[] args)
        {

            CheckPalindrom();
            Console.ReadLine();
        }
    }
}
