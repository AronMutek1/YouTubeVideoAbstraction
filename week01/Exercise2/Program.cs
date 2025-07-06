using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask user for grade percentage
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();

        // Convert string input to integer
        int grade = int.Parse(input);

        // Declare variables for letter and sign
        string letter = "";
        string sign = "";

        // Determine the letter grade
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Stretch Challenge: Add "+" or "-" signs, except for A+ and F+ or F-
        int lastDigit = grade % 10;

        if (letter != "A" && letter != "F")
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (letter == "A" && lastDigit < 3)
        {
            sign = "-";
        }

        // Display final letter grade
        Console.WriteLine($"Your grade is: {letter}{sign}");

        // Pass or fail message
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Better luck next time. Keep trying!");
        }
    }
}
