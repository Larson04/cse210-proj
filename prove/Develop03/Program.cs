using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        
        Scripture scripture1 = new Scripture("how are you?");

        scripture1.DisplayScripture();

        Words workingWord = new Words();

        workingWord.SetWord(scripture1.GetWord());

        workingWord.HideWord();

        



    }
}