using System;

namespace EventRegIceTask

{
    class Program
    {
        static void Main(string[] args)
        {
            EventManager manager = new EventManager();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nEvent Attendee Manager");
                Console.WriteLine("1. Add Attendee");
                Console.WriteLine("2. Remove Attendee");
                Console.WriteLine("3. Display All Attendees");
                Console.WriteLine("4. Exit");
                Console.Write("Please enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter attendee name to add: ");
                        string addName = Console.ReadLine();
                        manager.AddAttendee(addName);
                        break;

                    case "2":
                        Console.Write("Enter attendee name to remove: ");
                        string removeName = Console.ReadLine();
                        manager.RemoveAttendee(removeName);
                        break;

                    case "3":
                        manager.DisplayAllAttendees();
                        break;

                    case "4":
                        running = false;
                        Console.WriteLine("Exiting program. Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
