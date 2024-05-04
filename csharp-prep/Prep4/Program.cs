using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> RLnumbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int RLnum = -1;
        int RLsum = 0;
        // int RLavg = -0;
        while (RLnum != 0)
        {
            Console.Write("Enter number: ");
            RLnum = int.Parse(Console.ReadLine());
            if (RLnum == 0) break;
            else if (RLnum != 0)
            {
                RLnumbers.Add(RLnum);
                RLsum += RLnum;
            }
        }
        
        Console.WriteLine($"Sum: {RLsum}");
        
        double RLavg = RLdividing(RLnumbers, RLsum);
        Console.WriteLine($"Average: {RLavg}");

        int RLmax = RLsorting(RLnumbers);
        Console.WriteLine($"The largest number: {RLmax}");

        // RLnumbers.Sort((a,b) => b.CompareTo(a));
        // Console.WriteLine($"The Sorted list is: {RLnumbers}");
        
    }
    

    static double RLdividing(List<int> RLnumbers,int RLsum)
    {
        // Console.WriteLine(RLnumbers.Count);
        int RLnumCount = RLnumbers.Count;

        double RLavg = ((double)RLsum) / RLnumCount;

        return RLavg;
    }

    static int RLsorting(List<int> RLnumbers)
    {
        int RLmax = 0;
        foreach (int RLnum in RLnumbers)
        {
            if (RLnum > RLmax)
            {
                RLmax = RLnum;
            }
        }
        return RLmax;
    }
    static int RLsmallPos(List<int> RLnumbers)
    {
        int RLminPos = 0;
        foreach (int RLnum in RLnumbers)
        {
            if (RLnum < RLminPos && RLnum > 0)
            {
                RLminPos = RLnum;
            }
        }
        return RLminPos;
    }
}