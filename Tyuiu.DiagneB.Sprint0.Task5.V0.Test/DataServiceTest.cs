using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DiagneB.Sprint0.Task5.V0.Lib;

namespace Tyuiu.DiagneB.Sprint0.Task5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionValid()
        {

            Assert.AreEqual(10, DataService.Addition(5, 5));
        }
        [TestMethod]
        public void CheckedSoustractionValid()
        {

            Assert.AreEqual(5, DataService.Soustraction(10, 5));
        }
        [TestMethod]
        public void CheckedMultiplicationValid()
        {

            Assert.AreEqual(50, DataService.Multiplication(10, 5));
        }
        [TestMethod]
        public void CheckedDivisionValid()
        {

            Assert.AreEqual(3, DataService.Division(9, 3));
        }
    }
}
