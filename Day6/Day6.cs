using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    public class Day6
    {
        private class ArrayComparer : IEqualityComparer<int[]>
        {
            public bool Equals(int[] x, int[] y)
            {
                if (x.Length != y.Length)
                    return false;

                bool equals = true;

                for(int i = 0; i < x.Length; i++)
                {
                    if(x[i] != y[i])
                    {
                        equals = false;
                        break;
                    }
                }

                return equals;
            }

            public int GetHashCode(int[] obj)
            {
                if (obj == null)
                    return 0;
                int result = 1;
                foreach(var element in obj)
                    result = 31 * result + element;
                return result;
            }
        }

        static void Main(string[] args)
        {
            string input = "5	1	10	0	1	7	13	14	3	12	8	10	7	12	0	6";

            Console.WriteLine($"Part1: {Part1(input)}");
            Console.WriteLine($"Part2: {Part2(input)}");
        }

        public static int Part1(string input)
        {
            HashSet<int[]> seenPermutations = new HashSet<int[]>(new ArrayComparer());

            int[] banks = input.Split('\t').Select(n => int.Parse(n)).ToArray();

            int cycles = 0;
            bool alreadySeen = false;

            while (!alreadySeen)
            {
                int max = int.MinValue;
                int maxi = -1;

                for (int i = 0; i < banks.Length; i++)
                {
                    if (banks[i] > max)
                    {
                        max = banks[i];
                        maxi = i;
                    }
                }

                banks[maxi] = 0;

                while(max > 0)
                {
                    maxi = (maxi + 1) % banks.Length;
                    banks[maxi]++;
                    max--;
                }

                if(seenPermutations.Contains(banks))
                {
                    alreadySeen = true;
                }
                else
                {
                    seenPermutations.Add((int[])banks.Clone());
                }

                cycles++;
            }

            return cycles;
        }

        public static int Part2(string input)
        {
            Dictionary<int[], int> seenPermutations = new Dictionary<int[], int>(new ArrayComparer());

            int[] banks = input.Split('\t').Select(n => int.Parse(n)).ToArray();

            int cycles = 0;
            int duplicateStartCycle = 0;
            bool alreadySeen = false;

            while (!alreadySeen)
            {
                int max = int.MinValue;
                int maxi = -1;

                for (int i = 0; i < banks.Length; i++)
                {
                    if (banks[i] > max)
                    {
                        max = banks[i];
                        maxi = i;
                    }
                }

                banks[maxi] = 0;

                while (max > 0)
                {
                    maxi = (maxi + 1) % banks.Length;
                    banks[maxi]++;
                    max--;
                }

                cycles++;

                if (seenPermutations.ContainsKey(banks))
                {
                    alreadySeen = true;
                    duplicateStartCycle = seenPermutations[banks];
                }
                else
                {
                    seenPermutations.Add((int[])banks.Clone(), cycles);
                }
            }

            return cycles - duplicateStartCycle;
        }

    }
}
