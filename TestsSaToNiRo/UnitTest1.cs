using SaToNiRo;

namespace TestsSaToNiRo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestingForRegNumberInput()
        {
            string expected = "abc123";
            var result = Vehicle.GetUserRegNumber("abc123");   
            Assert.AreNotEqual(expected, result);
        }

        [TestMethod]
        public void TestingForCapitalRegNumberInput()
        {
            string expected = "ABC123";
            var result = Vehicle.GetUserRegNumber("abc123");
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestingForValidRegNumberInput()
        {
            string expected = "Ogiltigt registreringsnummer! Försök igen.";
            var result = Vehicle.GetUserRegNumber("123abc");
            Assert.AreEqual(expected, result);
        }
    }
}