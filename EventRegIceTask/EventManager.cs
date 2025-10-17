using System;
using System.Collections.Generic;

namespace EventRegIceTask

{
    public class EventManager
    {
        // Private field to store attendees
        private HashSet<string> attendees = new HashSet<string>();

        // Adds a new attendee
        public void AddAttendee(string name)
        {
            if (attendees.Add(name))
            {
                Console.WriteLine($"\"{name}\" has been registered successfully.");
            }
            else
            {
                Console.WriteLine($"\"{name}\" is already registered.");
            }
        }

        // Removes an attendee
        public void RemoveAttendee(string name)
        {
            if (attendees.Remove(name))
            {
                Console.WriteLine($"\"{name}\" has been removed.");
            }
            else
            {
                Console.WriteLine($"\"{name}\" was not found in the registration list.");
            }
        }

        // Displays all registered attendees
        public void DisplayAllAttendees()
        {
            Console.WriteLine("\n--- Registered Attendees ---");
            if (attendees.Count == 0)
            {
                Console.WriteLine("No one is registered yet.\n");
                return;
            }

            foreach (var attendee in attendees)
            {
                Console.WriteLine(attendee);
            }
            Console.WriteLine(); // Blank line for spacing
        }
    }
}
