using Microsoft.VisualStudio.TestTools.UnitTesting;
using CITest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CITest.Tests
{
    [TestClass()]
    public class udregningTests
    {
        [TestMethod()]
        public void PlusTest()
        {
            //Arrange
            udregning udregning = new udregning();

            //Act 
            int excpected = udregning.Plus(5, 5);

            //Assert
            Assert.AreEqual(10, excpected);
        }

        [TestMethod()]
        public void MinusTest()
        {
            //Arrange
            udregning udregning = new udregning();

            //Act 
            int excpected = udregning.Minus(5, 2);

            //Assert
            Assert.AreEqual(3, excpected);
        }
    }
}