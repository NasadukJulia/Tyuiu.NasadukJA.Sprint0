using Tyuiu.NasadukJA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.NasadukJA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {   
            var name = "Юля";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Юля", res);
        }
    }
}
