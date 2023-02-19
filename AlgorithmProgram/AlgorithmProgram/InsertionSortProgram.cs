using System;
namespace AlgorithmProgram
{
	public class InsertionSortProgram
	{
        public static void InsertionSort()
        {
            Console.WriteLine("Insertion Sort Program To Read Strings\n");
            Console.Write("Enter A Sentence Of Words : ");
            string strLine = Console.ReadLine();
            string[] strWord = strLine.Split(' ');
            int strLen = strWord.Length - 1;

            Perform.ISort(strWord);
            Console.Write("The values after performing insertion sort are : ");
            Perform.PrintArray(strWord, strLen);

        }
    }
}

