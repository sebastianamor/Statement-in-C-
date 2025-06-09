for (int i = 1; i <= 20; i++)
{
    // Check for divisibility by both 3 and 5 first
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine($"{i} - FizzBuzz");
    }
    // Then check for divisibility by 3
    else if (i % 3 == 0)
    {
        Console.WriteLine($"{i} - Fizz");
    }
    // Then check for divisibility by 5
    else if (i % 5 == 0)
    {
        Console.WriteLine($"{i} - Buzz");
    }
    // If none of the above, just print the number
    else
    {
        Console.WriteLine(i);
    }
}