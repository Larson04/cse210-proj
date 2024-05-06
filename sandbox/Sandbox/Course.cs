using System.ComponentModel.DataAnnotations;

class Course
{
    // attributes
    public string _courseCode;
    public string _courseName;
    public int _creditHours;
    public string _color;

    // methods/behaiviors
    public void Display()
    {
        Console.WriteLine($"{_courseCode} {_courseName} {_creditHours} {_color}");
    }
}