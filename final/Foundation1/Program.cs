using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World! \n ");

        List<Video> playlist = new List<Video>();

        Video video1 = new Video("How To Puick Up Chicks", "xXDarkDrag0n0fTheDarkXx", 120);
        video1.AddComment(new Comment("xXDarkDrag0n0fTheDarkXx", "Hey guys, don't forget to like and subscribe!"));
        video1.AddComment(new Comment("Slytherin4Eva", "Does this work on real girls?"));
        video1.AddComment(new Comment("DuckDuckMoose", "Look at the little floof ball!"));

        playlist.Add(video1);

        Video video2 = new Video("Drake Spotted in Local Park!", "xXDarkDrag0n0fTheDarkXx", 60);
        video2.AddComment(new Comment("DuckDuckMoose", "He's so handsome and proud! Look at that waddle!"));
        video2.AddComment(new Comment("DrakesGirl", "That's a duck, not Drake!"));
        video2.AddComment(new Comment("xXDarkDrag0n0fTheDarkXx", "I'm a joke channel bub."));

        playlist.Add(video2);

        Video video3 = new Video("Tiger Spotted in the Woods!", "xXDarkDrag0n0fTheDarkXx", 90);
        video3.AddComment(new Comment("BigCatsAreFriendShaped", "You got me good!"));
        video3.AddComment(new Comment("T-I-doubleGuh-er", "I feel like this might be too far, a plushie in a tree?"));
        video3.AddComment(new Comment("TomnJerry", "WHo else thought this guy was telling the truth?"));

        playlist.Add(video3);

        foreach(Video video in playlist)
        {
            Console.WriteLine("Title: " + video._title);
            Console.WriteLine("Creator: " + video._creator);
            Console.WriteLine($"Length: {video._length} seconds \n " );

            video.CommentCount();
            foreach (Comment comment in video._commentSection)
            {
                comment.DisplayComment();
                Console.WriteLine(" \n ");
            }
        }
    }
}