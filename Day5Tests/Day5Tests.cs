using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5.Tests
{
    [TestClass()]
    public class Day5Tests
    {
        [TestMethod()]
        public void Part1Test()
        {
            Assert.AreEqual(Day5.Part1("0\t2\t7\t0"), 5);
        }

        [TestMethod()]
        public void Part2Test()
        {
            Assert.AreEqual(Day5.Part2("0\t2\t7\t0"), 4);
        }
    }
}