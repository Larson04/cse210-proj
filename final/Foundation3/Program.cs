using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");

        List<Event> events = new List<Event>();
        // Center (BCTR, 50 W Viking St BYU, Rexburg, ID 83460

        events.Add(new Indoor("Graduation", "Graduation Ceremony where all the students are recognized and receive their diplomas", "07/25/2024", "5:00 pm", new Address("Center (BCTR Viking St BYU)", "Rexburg", "ID", "83460"), "Dr. Smith", 100));

        events.Add(new Outdoor("Carnival", "The Annual Carnival. Games and treats galore!", "05/30/2024", "10:00 am", new Address("123 Main Street", "Anytown", "CA", "12345"), "Rainy"));

        events.Add(new Reception("Addams Family Reunion", "Come meet all the new aunts, uncles, and cousins!", "10/31/2024", "4:00 pm", new Address("21 Chester Place", "Los Angeles", "CA", "90032"), "5PZdU@example.com"));

        foreach (Event eventItem in events)
        {
            if (eventItem is Reception)
            {
                Console.WriteLine("Reception:");
                eventItem.StandardMessage();
                (eventItem as Reception).FullDescription();
                (eventItem as Reception).ShortDescription();
                Console.WriteLine();
            }
            else if (eventItem is Indoor)
            {
                Console.WriteLine("Indoor Event:");
                eventItem.StandardMessage();
                (eventItem as Indoor).FullDetails();
                (eventItem as Indoor).ShortDesc();
                Console.WriteLine();
            }
            else if (eventItem is Outdoor)
            {
                Console.WriteLine("Outdoor Event:");
                eventItem.StandardMessage();
                (eventItem as Outdoor).FullDetails();
                (eventItem as Outdoor).ShortDesc();
                Console.WriteLine();
            }
        }

    }
}