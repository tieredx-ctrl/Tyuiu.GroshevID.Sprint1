using Tyuiu.GroshevID.Sprint1.Task4.V12.Lib;

namespace Tyuiu.GroshevID.Sprint1.Task4.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 0.5;
            double y = -0.25;
            double wait = 1;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
