using Tyuiu.GroshevID.Sprint1.Task3.V14.Lib;

namespace Tyuiu.GroshevID.Sprint1.Task3.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double number = 123;
            double wait = 321;
            var res = ds.ReverseNumber(number);
            Console.WriteLine(res);
            Assert.AreEqual(wait, res);
        }
    }
}
