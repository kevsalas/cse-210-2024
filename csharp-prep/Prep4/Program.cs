using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please add numbers to the list, enter 0 when finished.");
        List<int>numbers = new List<int>();
        string inputNumbers = Console.ReadLine();
        int numbersInputed = int.Parse(inputNumbers);
        numbers.Add(numbersInputed);
        while (numbersInputed != 0)
        {
            if (numbersInputed != 0){
                inputNumbers = Console.ReadLine();
                numbersInputed = int.Parse(inputNumbers);
                numbers.Add(numbersInputed);
                if (numbersInputed == 0){
                    numbers.RemoveAt(numbers.Count - 1);
                    int totalSum = numbers.Sum();
                    Console.WriteLine($"Total sum: {totalSum}");
                    double average = numbers.Count > 0 ? numbers.Average() : 0.0;
                    Console.WriteLine($"Average Number: {average}");
                    int largerNumber = numbers.Max();
                    Console.WriteLine($"Largest Number: {largerNumber}");
                }
            }
            }

               
        }

    }
