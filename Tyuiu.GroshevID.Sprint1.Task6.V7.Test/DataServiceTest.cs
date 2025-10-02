using Tyuiu.GroshevID.Sprint1.Task6.V7.Lib;

namespace Tyuiu.GroshevID.Sprint1.Task6.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string value = "World is a very bright place";
            DataService ds = new DataService();
            string res = ds.DeleteLastLetter(value);
            string wait = "Worl i ver brigh plac";
            Assert.AreEqual(wait, res);
        }
    }
}
