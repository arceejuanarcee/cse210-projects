using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        double gradePercentage = double.Parse(Console.ReadLine());

        string letter = "";

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >=80)
        {
            letter = "B";
        }
        else if (gradePercentage >=70)
        {
            letter = "C";
        }
         else if (gradePercentage >=60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (gradePercentage >=70)
        {
            Console.WriteLine($"Congratulations! You passed the course with a {letter} grade.");
        }
        else
        {
            Console.WriteLine($"You got a {letter}. You can do better next time!");
        }
    }
}