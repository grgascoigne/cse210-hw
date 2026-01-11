using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        
        List<int> numbers = new List<int>();
        int number = -1;

        while (number != 0)
        {
            Console.Write("Add a number to the list, or enter '0' to quit. ");
            string response = Console.ReadLine();
            number = int.Parse(response);

            if (number != 0)
            {
                numbers.Add(number);

            }
        }
        int sum = 0;
        foreach (int adding in numbers)
        {
            sum += adding;
        }
        Console.WriteLine($"The sum is: {sum}");
        
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");


        int maximum = numbers[0];
        
        foreach (int max in numbers)
        {
            if (max > maximum)
            {
                maximum = max;
            }
        }
        Console.WriteLine($"The maximum number is: {maximum}");
    }  
}