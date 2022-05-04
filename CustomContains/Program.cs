using System;

namespace CustomContains
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the sentence:");
            string sentence = Console.ReadLine();
            Console.WriteLine("\nEnter the word:");
            string word = Console.ReadLine();

            Console.WriteLine("\n" + sentence.CustomCont(word));
            
        }
    }
}
