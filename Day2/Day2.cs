using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public class Day2
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllLines("input.txt");

            Console.WriteLine($"Part1: {Part1(input)}");
            Console.WriteLine($"Part2: {Part2(input)}");
        }

        public static int Part1(string[] input)
        {
            int checksum = 0;

            foreach (var line in input)
            {
                int max = int.MinValue; int min = int.MaxValue;

                foreach(var n in line.Split('\t').Select(s => int.Parse(s)))
                {
                    if(n > max)
                        max = n;
                    if (n < min)
                        min = n;
                }

                checksum += max - min;
            }

            return checksum;
        }

        public static int Part2(string[] input)
        {
            int checksum = 0;

            foreach (var line in input)
            {
                int[] nums = line.Split('\t').Select(s => int.Parse(s)).ToArray();


                bool foundDivisible = false;

                // Go from left to right and check i versus j (both ways)
                for(int i = 0; i < (nums.Length - 1); i++)
                {
                    for(int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] % nums[j] == 0)
                        {
                            checksum += nums[i] / nums[j];
                            foundDivisible = true;
                            break;
                        }
                        else if (nums[j] % nums[i] == 0)
                        {
                            checksum += nums[j] / nums[i];
                            foundDivisible = true;
                            break;
                        }
                    }

                    if (foundDivisible)
                        break;
                }
            }

            return checksum;
        }
    }
}
