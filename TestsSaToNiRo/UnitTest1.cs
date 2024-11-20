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
            string expected = "Ogiltigt registreringsnummer! F�rs�k igen.";
            var result = Vehicle.GetUserRegNumber("123abc");
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestingForVehicleColor()
        {
            string expected = "R�d";
            var result = Vehicle.ChooseVehicleColor(1);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestingForValidVehicleColor()
        {
            string expected = "Ogiltlig f�rg! F�rs�k igen";
            var result = Vehicle.ChooseVehicleColor(99);
            Assert.AreEqual(expected, result);
        }
    }
}