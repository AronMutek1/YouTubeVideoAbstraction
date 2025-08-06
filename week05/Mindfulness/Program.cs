using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "";

        while (input != "4")
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select an option: ");
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    new BreathingActivity().Run();
                    break;
                case "2":
                    new ReflectionActivity().Run();
                    break;
                case "3":
                    new ListingActivity().Run();
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    Thread.Sleep(1000);
                    break;
            }
        }
    }
}

// Extra Features:
// 1. Spinner animation on all pauses
// 2. Countdown timer before listing
// 3. Tracks number of listed items
// 4. Well-structured inheritance and encapsulation
