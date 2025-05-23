using System;

public class nuñez
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 100; i++)
        {
            string output = "";
            if (i % 15 == 0) output = "fizzbuzz";
            else if (i % 3 == 0) output = "fizz";
            else if (i % 5 == 0) output = "buzz";
            else output = i.ToString();
            Console.WriteLine(output);
        }
        Console.ReadKey();
    }
}