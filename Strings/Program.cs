using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string aliceQuote = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";            
            string word;           

            Console.WriteLine("What word would you like to search for in the first sentence of the classic story 'Alice in Wonderland'?");
            word = Console.ReadLine();
            
            if (aliceQuote.ToLower().IndexOf(word)>-1)
            {
                Console.WriteLine("The word you chose to search for, " + word + ", appears in this quote.");
            }
            else
            {
                Console.WriteLine("The word you chose to search for, " + word + ", does not appear in this quote.");
            }
            
        }
    }
}
