using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class Day3
    {
        static void Main(string[] args)
        {
            long input = 361527;

            Console.WriteLine($"Part2: {Part2(input)}");
        }

        struct pos
        {
            public long x;
            public long y;
        }

        public static long Part2(long input)
        {
            Dictionary<pos, long> _values = new Dictionary<pos, long>();

            const int RIGHT = 0; const int UP = 1; const int LEFT = 2; const int DOWN = 3;

            long cur_val = 1;
            long pos_x = 0;
            long pos_y = 0;

            int cur_direction = DOWN;

            _values.Add(new pos { x = pos_x, y = pos_y }, cur_val); // Add the starting position

            int steps = 1; // First we take 2x1 steps, then 2x2 steps, 2x3, 2x4 and so on

            while (cur_val < input)
            {
                for (int i = 0; i < 2; i++)
                {
                    cur_direction = (cur_direction + 1) % 4;

                    for (int j = 0; j < steps; j++)
                    {
                        long new_val = 0;
                        switch (cur_direction)
                        {
                            case RIGHT:
                                pos_x++;
                                break;
                            case UP:
                                pos_y++;
                                break;
                            case LEFT:
                                pos_x--;
                                break;
                            case DOWN:
                                pos_y--;
                                break;
                        }

                        // Calculate values for current square
                        for (int x = -1; x <= 1; x++)
                        {
                            for (int y = -1; y <= 1; y++)
                            {
                                if (_values.ContainsKey(new pos { x = (pos_x + x), y = (pos_y + y) }))
                                {
                                    var pos = new pos { x = (pos_x + x), y = (pos_y + y) };
                                    new_val += _values[pos];
                                }
                            }
                        }

                        cur_val = new_val;
                        _values.Add(new pos { x = pos_x, y = pos_y }, cur_val);
                        if (cur_val > input)
                            return cur_val;
                    }
                }
                steps++;
            }

            return cur_val;
        }
    }
}
