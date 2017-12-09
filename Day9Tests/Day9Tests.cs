using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9.Tests
{
    [TestClass()]
    public class Day9Tests
    {
        [TestMethod()]
        public void Part1Test()
        {
            Assert.AreEqual(Day9.Part1("{}"), 1);
            Assert.AreEqual(Day9.Part1("{{{}}}"), 6);
            Assert.AreEqual(Day9.Part1("{{},{}}"), 5);
            Assert.AreEqual(Day9.Part1("{{{},{},{{}}}}"), 16);
            Assert.AreEqual(Day9.Part1("{<a>,<a>,<a>,<a>}"), 1);
            Assert.AreEqual(Day9.Part1("{{<ab>},{<ab>},{<ab>},{<ab>}}"), 9);
            Assert.AreEqual(Day9.Part1("{{<!!>},{<!!>},{<!!>},{<!!>}}"), 9);
            Assert.AreEqual(Day9.Part1("{{<a!>},{<a!>},{<a!>},{<ab>}}"), 3);
        }

        [TestMethod()]
        public void Part2Test()
        {
            Assert.AreEqual(Day9.Part2("<>"), 0);
            Assert.AreEqual(Day9.Part2("<random characters>"), 17);
            Assert.AreEqual(Day9.Part2("<<<<>"), 3);
            Assert.AreEqual(Day9.Part2("<{!>}>"), 2);
            Assert.AreEqual(Day9.Part2("<!!>"), 0);
            Assert.AreEqual(Day9.Part2("<!!!>>"), 0);
            Assert.AreEqual(Day9.Part2("<{o\"i!a,<{ i < a > "), 10);
        }

    }
}