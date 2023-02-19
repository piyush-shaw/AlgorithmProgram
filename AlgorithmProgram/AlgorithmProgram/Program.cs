using AlgorithmProgram;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Algorithm Program");
        while (true)
        {
            Console.WriteLine("1.String Permutation \n2.Binary String Search \n3.Insertion Sort \n4.Bubble Sort \n5.Merge Sort \n6.Anagram Detection");
            Console.WriteLine("Enter a choice from above");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    //Calling the string permutation method
                    Permutation.StringPermuation();
                    break;
                case 2:
                    //Calling the binary search string method
                    BinarySearch.BinarySearchWord();
                    break;
                case 3:
                    //Calling the insertion sort string method
                    InsertionSortProgram.InsertionSort();
                    break;
                case 4:
                    //Calling the bubble sort string method
                    BubbleSortProgram.BubbleSort();
                    break;
                case 5:
                    //Calling the merge sort string method
                    MergeSortProgram.MergeSort();
                    break;
                case 6:
                    //Calling the anagram detection method
                    Anagram.AnagramDetection();
                    break;
                default:
                    Console.WriteLine("Please choice the correct option");
                    break;
            }
        }
        
    }
}