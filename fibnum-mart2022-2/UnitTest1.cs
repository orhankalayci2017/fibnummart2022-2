﻿using NUnit.Framework;

namespace fibnum_mart2022_2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var fibNumGen = new FibNumGen(); 
            Assert.AreEqual(1,fibNumGen.getNum(1));
        }
    }
}
