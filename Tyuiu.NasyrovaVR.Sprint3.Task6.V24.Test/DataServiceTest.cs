using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NasyrovaVR.Sprint3.Task6.V24.Lib;

namespace Tyuiu.NasyrovaVR.Sprint3.Task6.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 17;
            int stopValue = 26;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 41;
            Assert.AreEqual(wait, res);
        }
    }
}
