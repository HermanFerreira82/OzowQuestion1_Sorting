using System;
using System.Diagnostics.CodeAnalysis;

namespace OzowQuestion1_Sorting
{
    [ExcludeFromCodeCoverage]
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "Contrary to popular belief, the pink unicorn flies east";

            Console.WriteLine($"CustomAsciiArraySorter: {new CustomAsciiArraySorter().Sort(testString)}");
            Console.WriteLine($"CustomDictionarySorter: {new CustomDictionarySorter().Sort(testString)}");
        }
    }
}
