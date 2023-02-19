using System;
namespace AlgorithmProgram
{
	public class PrimeNumber
	{
        public static void PrimeNumbers()
        {
            Console.WriteLine("Print Prime Numbers In A Given Range\n");
            Console.Write("Enter Starting Number : ");
            int startNum = int.Parse(Console.ReadLine());
            Console.Write("Enter Ending Number : ");
            int endNum = int.Parse(Console.ReadLine());
            Perform.PrintPrimeNum(startNum, endNum);
        }
    }
}

