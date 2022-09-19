﻿namespace Day16_17_DSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an option ");
            Console.WriteLine("1.Permutations of string\n2.Binary search");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter string for permutation: ");
                    string arr = Console.ReadLine();
                    Console.WriteLine("Permutation of string is: ");
                    
                    Permutations.PerformPermutation(arr, 0, arr.Length - 1);

                    
                    Console.WriteLine("Enter first string:");
                    string arr1 = Console.ReadLine();
                    Console.WriteLine("Enter second string:");
                    string arr2 = Console.ReadLine();
                    CheckArrayString.CheckString(arr1, arr2);
                    Console.WriteLine("string is" + CheckArrayString.CheckString(arr1, arr2));
                    break;

                    case 2:
                    BinarySearch.SearchWord();
                    break;
            }
        }
    }
}