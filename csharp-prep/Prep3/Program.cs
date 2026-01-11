using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        Console.WriteLine("Hello Prep3 World!");
        int magicnumber = randomGenerator.Next(1,100);
        Console.WriteLine("What is your guess? ");
        string guess = Console.ReadLine();
        int intguess = int.Parse(guess);

        while (intguess != magicnumber)
        {
        if (intguess < magicnumber)
        {
            Console.WriteLine("Higher");
            Console.WriteLine("What is your new guess? ");
            guess = Console.ReadLine();
            intguess = int.Parse(guess);
        }
        else if (intguess > magicnumber)
        {
            Console.WriteLine("Lower");
            Console.WriteLine("What is your new guess? ");
            guess = Console.ReadLine();
            intguess = int.Parse(guess);
        }
        }
        Console.WriteLine("You got the magic number!");
}
}