using System;

namespace Unit5ProjectLowe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Unit 5 project
            //Initialize Variables
            string sentence = "The quick brown fox jumps over the lazy dong";
            int current = 0;
            int blankPosition = 0;
            int wordCount = 0;
            string word;

            //Processing
            for (int i = 0; i < sentence.Length; i++)
            {
                current = i;

                blankPosition = sentence.IndexOf(" ", current);
                if ( blankPosition == -1)
                {
                    word = sentence.Substring(current);
                    i = sentence.Length;
                }
                else
                {
                    word = sentence.Substring(current, blankPosition - current);
                    i = blankPosition;
                }
                wordCount++;
                //display results
                Console.WriteLine(wordCount + " " + word);

            }
            Console.WriteLine("Total word count " + wordCount);
            Console.ReadKey();
        }
    }
}
