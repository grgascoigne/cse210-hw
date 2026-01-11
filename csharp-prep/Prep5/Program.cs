using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        
        DisplayWelcome();
        string UserName = PromptUserName();
        int userNum = PromptUserNumber();
        int squareNum = SquareNumber(userNum);
        int birthyear;

        PromptUserBirthYear(out birthyear);

        DisplayResult(UserName, squareNum, birthyear);
    }
        
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }
        
        static string PromptUserName()
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();

            return name;
        }

        static int PromptUserNumber()
        {
            Console.WriteLine("Please enter a number: ");
            string numberresponse = Console.ReadLine();
            int number = int.Parse(numberresponse);
            return number;
        }

        static int SquareNumber(int number)
        {
            int squared = number * number;
            return squared;
        }

        static int PromptUserBirthYear(out int birthyear)
        {
            Console.WriteLine("Please enter the year you were born: ");
            string birthresponse = Console.ReadLine();
            birthyear = int.Parse(birthresponse);
            return birthyear;

        }

        static void DisplayResult(string name, int square, int birthyear)
        {
            Console.WriteLine($"{name}, your number squared is {square}");
            Console.WriteLine($"{name}, you will turn {2026-birthyear} years old this year.");
        }
    }   
