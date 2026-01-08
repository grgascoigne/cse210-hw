using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What was your grade percentage in the class? ");
       string grade = Console.ReadLine();
       int percentage = int.Parse(grade);
    
        if (percentage >= 90)
        {
            Console.WriteLine("Your grade was an A. You passed!");
        }
        else if (percentage >= 80)
        {
            Console.WriteLine("Your grade was a B. You passed!");
        }
        else if (percentage >= 70)
        {
            Console.WriteLine("Your grade was a C. You passed!");
        }
        else if (percentage >= 60)
        {
            Console.WriteLine("Your grade was a D. You did not pass, you have valuable experience for next time!");
        }
        else
        {
            Console.WriteLine("Your grade was a F. You did not pass, you have valuable experience for next time!");
        }
    }
}