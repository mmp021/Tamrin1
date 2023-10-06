using System.Collections.Generic;
using System;
using System.Linq;

namespace Tamrin1
{

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please enter the first number: ");
                if (int.TryParse(Console.ReadLine(), out int number1))
                {
                    Console.Write("Please enter the second number: ");
                    if (int.TryParse(Console.ReadLine(), out int number2))
                    {
                        List<Number> numbers = new List<Number>();

                        for (int i = number1; i <= number2; i++)
                        {
                            numbers.Add(new MirrorNumber(i));
                            numbers.Add(new PrimeNumber(i));
                        }

                        int mirrorCount = 0;
                        int primeCount = 0;

                        List<int> mirrorNumbers = new List<int>();
                        List<int> primeNumbers = new List<int>();

                        foreach (var number in numbers)
                        {
                            if (number.IsMirror())
                            {
                                mirrorCount++;
                                mirrorNumbers.Add(number.Value);
                            }

                            if (number.IsPrime())
                            {
                                primeCount++;
                                primeNumbers.Add(number.Value);
                            }
                        }

                        Console.WriteLine($"Total mirror numbers: {mirrorCount}");
                        Console.WriteLine($"Mirror numbers: {string.Join(", ", mirrorNumbers)}");

                        Console.WriteLine($"Total prime numbers: {primeCount}");
                        Console.WriteLine($"Prime numbers: {string.Join(", ", primeNumbers)}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for the second number.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input for the first number.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }


}

