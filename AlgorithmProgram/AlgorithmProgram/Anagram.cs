﻿using System;
namespace AlgorithmProgram
{
	public class Anagram
	{
        //Method to check given strings are anagram detection
        public static void AnagramDetection()
        {
            Console.WriteLine("Anagram Detection Program\n");
            Console.Write("Enter the first string : ");
            string firstStr = Console.ReadLine();
            Console.Write("Enter the second string : ");
            string secStr = Console.ReadLine();

            if (Perform.IsAnagram(firstStr, secStr) == true)
                Console.WriteLine("The Given Strings Are Anagram\n");
            else
                Console.WriteLine("The Given Strings Are Not Anagram\n");
        }
    }
}

