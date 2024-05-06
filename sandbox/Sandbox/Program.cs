using System;

class Program
{
    static void Main(string[] args)
    {
        // for (int x = 0; x < 9; x++)
        // {
        //     Console.WriteLine("Howdy Sandbox World!");
        // }

        // Making course object
        Course course1 = new Course();
        course1._courseCode = "CSE 210";
        course1._courseName = "Prog. with Classes";
        course1._creditHours = 2;
        course1._color = "green";
        course1.Display();
    }
}

// for (int y = 9; y>3; y--)
// {
//     Console.WriteLine("Howdy");
// }

