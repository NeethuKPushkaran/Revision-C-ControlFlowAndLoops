using System;

namespace ControlFlowAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Control flow statements
            int number = 7;

            if (number > 5)
            {
                Console.WriteLine("The number is greater than 5.");
            }
            else if (number == 5)
            {
                Console.WriteLine("The number is equal to 5.");
            }
            else
            {
                Console.WriteLine("The number is less than 5.");
            }

            int day = 3;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                default:
                    Console.WriteLine("Another day");
                    break;
            }

            // Loops

            //for Loop

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("for loop iteration: " + i);
            }

            //foreach

            int[] numbers = { 1, 2, 3, 4, 5 };
            foreach (int num in numbers)
            {
                Console.WriteLine("foreach loop number: " + num);
            }

            //while

            int count = 0;
            while (count < 5)
            {
                Console.WriteLine("while loop count: " + count);
                count++;
            }

            //do-while
            count = 0;
            do
            {
                Console.WriteLine("do-while loop count: " + count);
                count++;
            } while (count < 5);

            //Parallel-foreach

            List<int> numbers1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Using Parallel.ForEach to process the numbers in parallel
            Parallel.ForEach(numbers1, num =>
            {
                // Simulate some work with a delay
                Console.WriteLine($"Processing number: {num} on thread {System.Threading.Thread.CurrentThread.ManagedThreadId}");
                System.Threading.Thread.Sleep(100);
            });

            Console.WriteLine("All numbers processed.");

            //Parallel LINQ

            List<int> numbers2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var parallelResult = numbers2.AsParallel().Where(n => n % 2 == 0).ToList();

            parallelResult.ForEach(n => Console.WriteLine($"Even number: {n}"));

            Console.WriteLine("All even numbers processed.");
        }
    }
}