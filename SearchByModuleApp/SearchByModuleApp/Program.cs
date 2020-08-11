using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;

namespace SearchByModuleApp
{
    class Program
    {
        public static int SearchAndSumByModule()
        {
            int[] numberArray = { 1, 2, 3, 4, 5, 6, 7, 8, 11, 17, 9, 10 };
            int[] oddNumbers = new int[numberArray.Length];
            for (var i = 1; i < numberArray.Length; i++)
            {
                if(numberArray[i] % 2 != 0)
                {
                    oddNumbers[i] = numberArray[i];
                  
                }
            }
            var oddNumbersFix = oddNumbers.Where(r => r != 0).ToArray();
            List<int> oddNumbersNew = new List<int>();
            for (int i = 1; i < oddNumbersFix.Length; i += 2)
            {
                oddNumbersNew.Add(oddNumbersFix[i]);
                Console.WriteLine(oddNumbersFix[i]);
            }
            int sum = 0; 
            for (int i = 0; i < oddNumbersNew.Count; i++)
            {
                sum += Math.Abs(oddNumbersNew[i]);
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine($"Sum module : {SearchAndSumByModule()}");
            Console.ReadLine();
        }
    }
}
