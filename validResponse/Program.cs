using System;

class Program
{
    static void Main()
    {
        string input;

        do
        {
            Console.WriteLine("Your response must be 'yes' or 'no'");
            Console.WriteLine("Please enter the text:");
            input = Console.ReadLine().ToLower();
        }
        while (input != "yes" && input != "no");

        Console.WriteLine("You entered: " + input);
        Console.ReadLine();
    }
}
