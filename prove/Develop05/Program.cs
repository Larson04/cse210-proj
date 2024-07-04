using System;
using System.ComponentModel;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        
        int score=0;

        string userChoice = "";

        while (userChoice != "8")
        {
            Console.WriteLine("Menu Options: \n 1. New Eternal Goal\n 2. New Simple Goal\n 3. New Check Goal\n 4. View Existing and Score\n 5. Update Existing\n 6. Save Goals\n 7. Load Goals\n 8. Quit");
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            { // Eternal
                Console.Write("What is the name of this goal? ");
                string name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();
                Console.Write("How many points is this goal worth? ");
                int points = int.Parse(Console.ReadLine());
                DateTime dateTime = DateTime.Now;
                string date = dateTime.ToString("MM/dd/yyyy");

                Eternal eternal = new Eternal(name, description, points, false, date, new List<string> { });

                // string eternalGoals = eternal.ListSave()
                Goal._goalList.Add(eternal);
            }
            else if (userChoice == "2")
            { // Simple
                Console.Write("What is the name of this goal? ");
                string name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();
                Console.Write("How many points is this goal worth? ");
                int points = int.Parse(Console.ReadLine());     

                Simple simple = new Simple(name, description, points, false);  

                // string simpleGoals = simple.ListSave();

                Goal._goalList.Add(simple);
            }
            else if (userChoice == "3")
            { // check
                Console.Write("What is the name of this goal? ");
                string name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();
                Console.Write("How many points is this goal worth? ");
                int points = int.Parse(Console.ReadLine());  
                Console.Write("How many times do you wish to complete this goal? ");
                int checkCount = int.Parse(Console.ReadLine());
                int bonus = points * 2;

                Check check = new Check(name, description, points, false, bonus, checkCount, 0);  

                // string checkGoals = check.ListSave(); 
                Goal._goalList.Add(check);            
            }
            else if (userChoice == "4")
            {//view
                foreach(Goal goal in Goal._goalList)
                {
                    goal.Display();
                }
                Console.WriteLine(score);
            }
            else if (userChoice == "5")
            { // update
                Console.Write("What is the type of the goal you would like to update: ");
                string type = Console.ReadLine();
                if (type == "eternal")
                {
                    Eternal eternal =new Eternal("", "", 0, false, "", new List<string> { });
                    eternal.Update();
                    string eternalGoals = eternal.ListSave();
                    score += eternal._points;
                }
                else if (type == "simple")
                {
                    Simple simple = new Simple("", "", 0, false);
                    simple.Update();
                    string simpleGoals = simple.ListSave();
                    score += simple._points;
                }
                else if (type == "check")
                {
                    Check check = new Check("", "", 0, false, 0, 0, 0);
                    check.Update();
                    string checkGoals = check.ListSave();
                    score += check._points;
                }
            }
            else if (userChoice == "6")
            { // save
                
            }   
            else if (userChoice == "7")
            { // load
                SaveFile.LoadFile(Goal._goalList);
            }
            else if (userChoice == "8")
            { // quit
                Console.WriteLine("Goodbye!");
                break;
            }
        }

    }
}