using System;

class myParams
{
    static void Main()
    {
        Random random = new Random();

        Console.Write("Enter the number of values that you want to generate! ");
        int numberOfValues = int.Parse(Console.ReadLine());

        int[] numbers = new int[numberOfValues];

        for (int i = 0; i < numberOfValues; i++)
        {
            numbers[i] = random.Next(1, 101);
        }

        Console.WriteLine("Random numbers generated:");
        for (int i = 0; i < numberOfValues; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();

        Console.WriteLine("All of the numbers added up: " + Add(numbers));

        Console.WriteLine("All of the numbers multiplied together: " + Multiply(numbers));
    }

    static int Add(params int[] values)
    {
        int total = 0;
        foreach (int value in values)
        {
            total += value;
        }
        return total;
    }

    static int Multiply(params int[] values)
    {
        int total = 1;
        foreach (int value in values)
        {
            total *= value;
        }
        return total;
    }
}
