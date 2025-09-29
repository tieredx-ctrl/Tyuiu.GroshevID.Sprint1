using Tyuiu.GroshevID.Sprint1.Task3.V9.Lib;

namespace Tyuiu.GroshevID.Sprint1.Task3.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int minutes = 150;
            double wait = 2.5;
            var res = ds.ConvertMinutesToHours(minutes);
            Assert.AreEqual(wait, res);
        }
    }
}
