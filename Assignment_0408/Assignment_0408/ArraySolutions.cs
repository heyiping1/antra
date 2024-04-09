using System.Collections.Generic;

namespace Assignment_0408
{
    public class ArraySolutions
    {
        public void copyArray(int[] orig)
        {
            int[] copy = new int[orig.Length];
            for (int i = 0; i < orig.Length; i++)
            {
                copy[i] = orig[i];
            }
            Console.WriteLine("Original:");
            foreach (var value in orig)
            {
                Console.Write($"{value} ");
            }
            Console.WriteLine("\nCopy:");
            foreach (var value in copy)
            {
                Console.Write($"{value} ");
            }
        }

        public void manageList() {
            List<string> list = new List<string>();
            while (true)
            {
                Console.WriteLine("Enter command (+ item, - item, -- to clear, or q to quit):");
                string input = Console.ReadLine();
                if (input.StartsWith("+"))
                {
                    string item = input.Substring(1).Trim();
                    list.Add(item);
                }
                else if (input.StartsWith("--") || input == "-")
                {
                    list.Clear();
                }
                else if (input.StartsWith("-"))
                {
                    string item = input.Substring(1).Trim();
                    list.Remove(item);
                }
                else if (input == "q")
                {
                    break;
                } 
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                Console.WriteLine("Current List:");
                foreach (var value in list)
                {
                    Console.WriteLine(value);
                }
            }
        }

        public int[] FindPrimesInRange(int startNum, int endNum)
        {
            List<int> primes = new List<int>();

            for (int num = startNum; num <= endNum; num++)
            {
                Boolean isPrime = true;
                if (num <= 1)
                {
                    isPrime = false;
                }
                else
                {
                    for (int i = 2; i * i <= num; i++)
                    {
                        if (num % i == 0)
                        {
                            isPrime = false;
                        }
                    }
                }
                if (isPrime)
                {
                    primes.Add(num);
                }
            }
            Console.WriteLine($"All primes within {startNum} and {endNum}:");
            foreach (var value in primes)
            {
                Console.WriteLine(value);
            }
            return primes.ToArray();
        }


        public void rotateAndSum(int[] array, int rotation)
        {
            int n = array.Length;
            int[] rotated = new int[n];
            int[] sum = new int[n];
            for (int i = 1; i <= rotation; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    rotated[(i + j) % n] = array[j];
                    sum[(i + j) % n] += rotated[(i + j) % n];
                }
            }
            Console.WriteLine("Sum Array:");
            foreach (var value in sum)
            {
                Console.WriteLine(value);
            }
        }

        public void findLongestSequence(int[] sequence)
        {
            int start = 0;
            int curr = 1;
            int longest = 1;
            for (int i = 1; i < sequence.Length; i++)
            {
                if (sequence[i] == sequence[i - 1])
                {
                    curr++;
                    if (curr > longest)
                    {
                        longest = curr;
                        start = i - curr + 1;
                    }
                }
                else
                {
                    curr = 1;
                }
            }
            Console.WriteLine("Longest sequence:");
            for (int i = start; i < start + longest; i++)
            {
                Console.Write(sequence[i] + " ");
            }
        }

        public void findMostFrequentNumber(int[] numbers)
        {
            Dictionary<int, int> freqs = new Dictionary<int, int>();
            foreach (int num in numbers)
            {
                if (!freqs.ContainsKey(num))
                {
                    freqs[num] = 0;
                }
                freqs[num]++;
            }
            int maxFreq = 0;
            int mostFreqNum = 0;
            foreach (int num in freqs.Keys)
            {
                if (freqs[num] > maxFreq)
                {
                    maxFreq = freqs[num];
                    mostFreqNum = num;
                }
            }
            Console.WriteLine($"The number {mostFreqNum} is the most frequent (occurs {maxFreq} times)");
        }
    }
}
