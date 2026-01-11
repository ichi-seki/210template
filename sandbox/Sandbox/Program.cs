using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade persentage: ");
        string grade = Console.ReadLine();
        int persentage = int.Parse(grade);
        string letter = "";

        if (persentage >= 90)
        {
            letter = "A";
        }
        else if (persentage >= 80)
        {
            letter = "B";
        }
        else if (persentage >= 70)
        {
            letter = "C";
        }
        else if (persentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.Write($"Your grade is {letter}");
}
}