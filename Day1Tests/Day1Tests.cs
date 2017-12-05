using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Tests
{
    [TestClass()]
    public class Day1Tests
    {
        [TestMethod()]
        public void Part1Test()
        {
            Assert.AreEqual(Day1.Part1("1122", 1), 3);
            Assert.AreEqual(Day1.Part1("1111", 1), 4);
            Assert.AreEqual(Day1.Part1("1234", 1), 0);
            Assert.AreEqual(Day1.Part1("91212129", 1), 9);
        }

        [TestMethod()]
        public void Part2Test()
        {
            Assert.AreEqual(Day1.Part2("1212"), 6);
            Assert.AreEqual(Day1.Part2("1221"), 0);
            Assert.AreEqual(Day1.Part2("123425"), 4);
            Assert.AreEqual(Day1.Part2("123123"), 12);
            Assert.AreEqual(Day1.Part2("12131415"), 4);
        }

    }
}