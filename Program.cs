using System;

namespace CMP1903MWorkshopCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Week 5
            //Challenge: What are the valid pass phrases?
            //
            int lineNumber = 1;
            int numberOfSame = 0;
            bool sameWord = false;
            string[] lines = File.ReadAllLines("Week 5 Text Codes.txt");
            foreach (string line in lines)
            {
                string[] words= line.Split(' ');
                int numberOfWords= words.Length;
                for (int i = 0; i < numberOfWords; i++)
                {
                    for (int j = 0; j < (numberOfWords-(i+1)); j++)
                    {
                        string word = words[numberOfWords - (i + 1)];
                        if (word == words[j])
                        {
                            sameWord = true;
                            numberOfSame++;
                        }
                    }
                }
                if (sameWord)
                {
                    Console.WriteLine((numberOfSame*2).ToString() + " words on line " + lineNumber.ToString() + " are the same!");
                   

                }
                else
                {
                    Console.WriteLine("No words on line " + lineNumber.ToString() + " are the same!");
                }
                lineNumber++;
                numberOfSame = 0;
                sameWord = false;

            }

            //Week 5
            //Task 1: Add a page to the 'history'
            //Task 2: Add exceptions
            //Task 3: Use custom exceptions

            //example of creating a page with a title and URL
            //Test... remove this when you have seen it working
            /*
            Page p = new Page("Test Page", "http://www.lincoln.ac.uk");
            Console.WriteLine(p.Address);
            //.......

            //creating a new, empty history
            History h1 = new History();
            */

        }
    }
}
