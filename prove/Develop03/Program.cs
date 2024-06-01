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
        Console.WriteLine("Press enter to continue, press 'q' to quit");
        while (true)
        {   
            reference.DisplayReference();
            scripture1.DisplayScripture();

            
            workingWord.SetWord(scripture1.GetWord());
            scripture1.SetWord(workingWord.HideWord());
            
            var key = Console.ReadKey(true).Key;

            if (key == ConsoleKey.Q)
            {
                // If user pressed 'q', exit the loop
                break;
            }
            else if (key == ConsoleKey.Enter)
            {
                // If user pressed Enter, continue the loop
                continue;
            }
        }

    }
}