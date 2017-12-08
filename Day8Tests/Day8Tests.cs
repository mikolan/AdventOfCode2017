using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void Part1Test()
        {
            string[] input =
            {
                "b inc 5 if a > 1",
                "a inc 1 if b < 5",
                "c dec -10 if a >= 1",
                "c inc -20 if c == 10"
            };

            Assert.AreEqual(Day8.Part1(input), 1);
        }

        [TestMethod()]
        public void Part2Test()
        {
            string[] input =
            {
                "b inc 5 if a > 1",
                "a inc 1 if b < 5",
                "c dec -10 if a >= 1",
                "c inc -20 if c == 10"
            };

            Assert.AreEqual(Day8.Part2(input), 10);
        }
    }
}