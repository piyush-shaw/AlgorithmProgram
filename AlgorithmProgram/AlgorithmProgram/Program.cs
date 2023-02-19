using AlgorithmProgram;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Algorithm Program");
        while (true)
        {
            Console.WriteLine("1.String Permutation \n2.Binary String Search");
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
                default:
                    Console.WriteLine("Please choice the correct option");
                    break;
            }
        }
        
    }
}