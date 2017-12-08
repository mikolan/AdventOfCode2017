using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    public class Day8
    {
        private static Dictionary<string, int> registers;
        static void Main(string[] args)
        {
            var input = File.ReadAllLines("input.txt");

            Console.WriteLine($"Part1: {Part1(input)}");
            Console.WriteLine($"Part2: {Part2(input)}");
        }

        public static int Part1(string[] input)
        {
            registers = new Dictionary<string, int>();

            foreach(var line in input)
            {
                var cols = line.Split(' ');
                string reg = cols[0];
                string op = cols[1];
                int val = int.Parse(cols[2]);
                string x = cols[4];
                string cond = cols[5];
                int condVal = int.Parse(cols[6]);

                InitRegisters(new[] { reg, x });

                if (CheckCondition(cond, registers[x], condVal))
                {
                    switch (op)
                    {
                        case "inc":
                            {
                                registers[reg] += val;
                                break;
                            }
                        case "dec":
                            {
                                registers[reg] -= val;
                                break;
                            }
                        default:
                            throw new ArgumentException($"Unknown operator: {op}");
                    }
                }
            }

            return registers.Values.Max();
        }

        public static int Part2(string[] input)
        {
            registers = new Dictionary<string, int>();
            int globalMax = int.MinValue;

            foreach (var line in input)
            {
                var cols = line.Split(' ');
                string reg = cols[0];
                string op = cols[1];
                int val = int.Parse(cols[2]);
                string x = cols[4];
                string cond = cols[5];
                int condVal = int.Parse(cols[6]);

                InitRegisters(new[] { reg, x });

                if (CheckCondition(cond, registers[x], condVal))
                {
                    switch (op)
                    {
                        case "inc":
                            {
                                registers[reg] += val;
                                if (registers[reg] > globalMax)
                                    globalMax = registers[reg];
                                break;
                            }
                        case "dec":
                            {
                                registers[reg] -= val;
                                if (registers[reg] > globalMax)
                                    globalMax = registers[reg];
                                break;
                            }
                        default:
                            throw new ArgumentException($"Unknown operator: {op}");
                    }
                }
            }

            return globalMax;
        }

        private static void InitRegisters(string[] v)
        {
            foreach(var r in v)
            {
                if(!registers.ContainsKey(r))
                {
                    registers[r] = 0;
                }
            }
        }

        public static bool CheckCondition(string condition, int val1, int val2)
        {
            switch(condition)
            {
                case ">":
                    return val1 > val2;
                case "<":
                    return val1 < val2;
                case "==":
                    return val1 == val2;
                case ">=":
                    return val1 >= val2;
                case "<=":
                    return val1 <= val2;
                case "!=":
                    return val1 != val2;
                default:
                    throw new ArgumentException($"Unknown conditional operator: {condition}");
            }
        }
    }
}
