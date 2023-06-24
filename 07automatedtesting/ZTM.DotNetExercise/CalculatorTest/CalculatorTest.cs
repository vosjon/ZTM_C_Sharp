namespace CalculatorTest
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Calculator_Add_Returns55For25And30()
        {
            var result = Calculator.Add(25, 30);

            Assert.AreEqual(55, result);
        }

        [TestMethod]
        public void Calculator_Subtract_Returns10For15Minus5()
        {
            var result = Calculator.Subtract(15, 5);

            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void Calculator_Multiply_Returns100For10And10()
        {
            var result = Calculator.Multiply(10, 10);

            Assert.AreEqual(100, result);
        }

        [TestMethod]
        public void Calculator_Divide_Returns50For100DividedBy2()
        {
            var result = Calculator.Divide(100, 2);

            Assert.AreEqual(50, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Calculator_Divide_ThrowsExceptionFor100And0()
        {
            Calculator.Divide(100, 0);
        }
    }
}