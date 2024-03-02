using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your grade percentage:");
        int gradePercentage = int.Parse(Console.ReadLine());

        string letter;
        
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine the sign
        int lastDigit = gradePercentage % 10;
        string sign = "";
        if (letter != "F") // Exclude F grades
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

        // Handle exceptional cases (A+ and F)
        if (letter == "A" && lastDigit >= 7)
        {
            sign = "";
        }
        else if (letter == "F" && lastDigit <= 3)
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed");
        }
        else
        {
            Console.WriteLine("Keep working! You'll get it next time.");
        }
    }
}
