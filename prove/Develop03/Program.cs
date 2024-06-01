using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Console.WriteLine();

        Reference reference = new Reference("1 Nephi", 3, 7, 0);
        Scripture scripture1 = new Scripture("And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");

        Words workingWord = new Words();
        reference.DisplayReference();
        scripture1.DisplayScripture();
        Console.WriteLine("Press enter to continue, type 'quit' to quit");
        string input = Console.ReadLine();
        
        int count = 0;
        int hiddenWords = 0;

          
        while (input != "quit")
        {
            count = 0;
            
            while ((count < 3) && (hiddenWords < 5000))
            {

                workingWord.SetWord(scripture1.GetWord());
                // Console.WriteLine("3");

                int checkHidden = workingWord.CheckIfHidden();

                if (checkHidden == 1)
                {
                    workingWord.SetWord(scripture1.GetWord());
                    // Console.WriteLine("3");
                    hiddenWords ++;
                }
                else
                {
                    scripture1.SetWord(workingWord.HideWord());
                    // Console.WriteLine("4");
                    count ++;
                    hiddenWords = 0;
                }
            }
            Console.Clear();
            reference.DisplayReference();
            // Console.WriteLine("1");
            scripture1.DisplayScripture();
            // Console.WriteLine("2");

            Console.WriteLine("Press enter to continue, type 'quit' to quit");
            input = Console.ReadLine();
        }
            
    }
}