﻿using System;
namespace AlgorithmProgram
{
	public class Perform
	{
        //Method to swap the characters of the string
        public static string Swap(string str, int start, int end)
        {
            char temp;
            char[] charArray = str.ToCharArray();
            temp = charArray[start];
            charArray[start] = charArray[end];
            charArray[end] = temp;
            string newStr = new string(charArray);
            return newStr;
        }

        //Method to perform the permutation of the String.
        public static void StringPermutation(string permStr, int start, int end)
        {
            if (start == end)
                Console.WriteLine(" " + permStr);
            else
            {
                for (int i = start; i <= end; i++)
                {
                    permStr = Swap(permStr, start, i);
                    StringPermutation(permStr, start + 1, end);
                    permStr = Swap(permStr, start, i);
                }
            }
        }
        //Generics method of binary search for different datatype 
        public static bool BinarySearch<T>(T[] list, T search) where T : IComparable
        {
            int startPos = 0;
            int endPos = list.Length - 1;
            while (startPos <= endPos)
            {
                int midLen = startPos + (endPos - startPos) / 2;
                int result = search.CompareTo(list[midLen]);

                //Checking If the string is present at the middle 
                if (result == 0)
                    return true;

                // If string is greater, ignore left half
                if (result > 0)
                    startPos = midLen + 1;
                else
                    // If string is smaller, ignore right half
                    endPos = midLen - 1;
            }

            return false;
        }
        //Method to Sort the array of string according to lengths by implementing insertion sort
        public static void ISort<T>(T[] arrGen) where T : IComparable
        {
            int arrLen = arrGen.Length;
            for (int i = 1; i < arrLen; ++i)
            {
                T temp = arrGen[i];
                int j = i - 1;

                // Move elements of arr[0..i-1], that are greater than key to one position ahead of their current position
                while (j >= 0 && arrGen[j].CompareTo(temp) > 0)
                {
                    arrGen[j + 1] = arrGen[j];
                    j--;
                }
                arrGen[j + 1] = temp;
            }
        }

        //Method to print an array
        public static void PrintArray<T>(T[] str, int len)
        {
            for (int i = 0; i <= len; i++)
                Console.Write(str[i] + " ");
            Console.WriteLine();
        }
    }
}

