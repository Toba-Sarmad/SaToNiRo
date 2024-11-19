using SaToNiRo;

namespace TestsSaToNiRo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestingForValidRegNumberInput()
        {
            string expected = "ABC123";
            var result = Vehicle.GetUserRegNumber();   
            Assert.AreEqual(expected, result);
        }
    }
}