using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");

        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Roberto Carlos", "Fractions", "Section 7.3", "8-19");

        Console.WriteLine(mathAssignment.GetSummary());

        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Eunice Anning", "European History", "The Causes of World War II");

        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}