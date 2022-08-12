using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DucksSheds;

namespace DucksShedsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_OneShedOneStack()
        {
            Sheds sd = new Sheds(0,0);
            sd.needs(10);
            int nSheds = sd.getSheds();
            int stacks = sd.getStacks();
            Assert.AreEqual(nSheds, 1);
            Assert.AreEqual(stacks, 1);
        }
        [TestMethod]
        public void Test_OneShedTwoStack()
        {
            Sheds sd = new Sheds(0, 0);
            sd.needs(22);
            int nSheds = sd.getSheds();
            int stacks = sd.getStacks();
            Assert.AreEqual(nSheds, 1);
            Assert.AreEqual(stacks, 2);
        }
        [TestMethod]
        public void Test_OneShedThreeStack()
        {
            Sheds sd = new Sheds(0, 0);
            sd.needs(30);
            int nSheds = sd.getSheds();
            int stacks = sd.getStacks();
            Assert.AreEqual(nSheds, 1);
            Assert.AreEqual(stacks, 3);
        }
        [TestMethod]
        public void Test_TwoShedsOneStacks()
        {
            Sheds sd = new Sheds(0, 0);
            sd.needs(31);
            int nSheds = sd.getSheds();
            int stacks = sd.getStacks();
            Assert.AreEqual(nSheds, 2);
            Assert.AreEqual(stacks, 1);
        }
        [TestMethod]
        public void Test_TwoShedstwoStacks()
        {
            Sheds sd = new Sheds(0, 0);
            sd.needs(52);
            int nSheds = sd.getSheds();
            int stacks = sd.getStacks();
            Assert.AreEqual(nSheds, 2);
            Assert.AreEqual(stacks, 2);
        }
        [TestMethod]
        public void Test_TwoShedsthreeStacks()
        {
            Sheds sd = new Sheds(0, 0);
            sd.needs(60);
            int nSheds = sd.getSheds();
            int stacks = sd.getStacks();
            Assert.AreEqual(nSheds, 2);
            Assert.AreEqual(stacks, 3);
        }
        [TestMethod]
        public void Test_NeedsMethod()
        {
            Sheds sd = new Sheds(0, 0);
            sd.needs(1000);
            int nSheds = sd.getSheds();
            int stacks = sd.getStacks();
            Assert.AreEqual(nSheds, 34);
            Assert.AreEqual(stacks, 1);
        }
    }
}
