using Tyuiu.GroshevID.Sprint1.Task5.V7.Lib;

namespace Tyuiu.GroshevID.Sprint1.Task5.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double f = 1;
            DataService ds = new DataService();
            int h = ds.AngleToHoursMinutes(f);
            int wait = 0;
            Assert.AreEqual(wait, h);
        }
    }
}
