using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number score you have in class.");
        int numberGrade = int.Parse(Console.ReadLine());
        if (numberGrade >= 100) {
            Console.WriteLine($"Letter Grade: A+");
            Console.WriteLine("Wow! 100… That's impressive!");
        } else if (numberGrade >= 90) {
            Console.WriteLine($"Letter Grade: A");
            Console.WriteLine("Very nice!");
        } else if (numberGrade >= 80) {
            Console.WriteLine($"Letter Grade: B");
            Console.WriteLine("Keep it up!");
        } else if (numberGrade >= 70) {
            Console.WriteLine($"Letter Grade: C");
            Console.WriteLine("You got this, keep working!");
        } else if (numberGrade >= 60) {
            Console.WriteLine($"Letter Grade: D");
            Console.WriteLine("Keep trying!");
        } else {
            Console.WriteLine($"Letter Grade: E");
            Console.WriteLine("Don't give up!");
        }
    }
}
