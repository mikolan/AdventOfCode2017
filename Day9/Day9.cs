using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    public class Day9
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText("input.txt");

            Console.WriteLine($"Part1: {Part1(input)}");
            //Console.WriteLine($"Part1: {Part2(input)}");
        }

        public static int Part1(string input)
        {
            int currentLevel = 1;
            int score = 0;
            TraverseGroup(input, 0, currentLevel, ref score);

            return score;
        }

        private static int TraverseGroup(string input, int offset, int currentLevel, ref int currentScore)
        {
            int i = offset + 1;

            // Traverse the string until we find another '}', which closes the group.
            while(true)
            {
                if (input[i] == '}')
                {
                    currentScore += currentLevel;
                    break;
                }

                if(input[i] == '<')
                {
                    bool foundGarbageClose = false;

                    while(!foundGarbageClose)
                    {
                        // Find the next > and check if it's legit.
                        i = input.IndexOf('>', i + 1);

                        if (input[i - 1] == '!')
                        {
                            int counter = 1;
                            int foo = i - 2;
                            while(input[foo] == '!')
                            {
                                counter++;
                                foo--;
                            }

                            if (counter % 2 == 0)
                                foundGarbageClose = true;
                        }
                        else
                        {
                            foundGarbageClose = true;
                        }
                    }
                }

                if (input[i] == '{')
                {
                    i = TraverseGroup(input, i, currentLevel + 1, ref currentScore);
                }
                i++;
            }

            return i;

        }

        public static int Part2(string input)
        {
            return -1;
        }
    }
}
