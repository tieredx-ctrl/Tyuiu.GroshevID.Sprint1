﻿using Tyuiu.GroshevID.Sprint1.Task7.V6.Lib;

namespace Tyuiu.GroshevID.Sprint1.Task7.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = -22;
            var z = ds.Calculate(x, y);
            Assert.AreEqual(wait, z);
        }
    }
}
