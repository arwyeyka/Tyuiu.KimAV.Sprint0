using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KimAV.Sprint0.Task6.V0.Lib;
namespace Tyuiu.KimAV.Sprint0.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAddictionArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.AdditionArray(numbers);
            Assert.AreEqual(15, res);
        }
        [TestMethod]
        public void CheckedSubstractionArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.SubstractionArray(numbers);
            Assert.AreEqual(-15, res);
        }
        [TestMethod]
        public void CheckedMultArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.MultiplicationArray(numbers);
            Assert.AreEqual(120, res);
        }
    }
}
