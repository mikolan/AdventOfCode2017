using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.Tests
{
    [TestClass()]
    public class Day2Tests
    {
        [TestMethod()]
        public void Part1Test()
        {
            string[] testInput =
            {
                "5\t1\t9\t5",
                "7\t5\t3",
                "2\t4\t6\t8"
            };

            Assert.AreEqual(Day2.Part1(testInput), 18);
        }

        [TestMethod()]
        public void Part2Test()
        {
            string[] testInput =
            {
                "5\t9\t2\t8",
                "9\t4\t7\t3",
                "3\t8\t6\t5"
            };

            Assert.AreEqual(Day2.Part2(testInput), 9);
        }
    }
}