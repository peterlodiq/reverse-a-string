using System;

namespace ReverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This application writes down the chosen array of letters backwards.");
            Console.WriteLine("Please enter the characters:");
            string word = Console.ReadLine();
            string revword = "";
            for (int i = word.Length - 1; i > -1; i--)
            {
                revword += word[i];
            }
            Console.WriteLine("The characters reversed: " + revword);
        }
    }
}
