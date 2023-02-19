using System;
namespace AlgorithmProgram
{
	public class MergeSortProgram
	{
        public static void MergeSort()
        {
            Console.WriteLine("Merge Sort Program To Sort Strings\n");
            Console.Write("Enter A Sentence Of Words : ");
            string strLine = Console.ReadLine();
            string[] strWord = strLine.Split(' ');

            Console.Write("Array Before Sorting : ");
            int strLen = strWord.Length - 1;
            Perform.PrintArray(strWord, strLen);

            Perform.Sort(strWord, 0, strLen);
            Console.Write("The values after performing merge sort are : ");
            Perform.PrintArray(strWord, strLen);

        }
    }
}

