namespace AccountingSystemTest
{
    [TestClass]
    public class AccountingSystemTest
    {
        [TestMethod]
        public void Checking_Account_Value_Returns1000After500And500()
        {
            var checking = new Checking(1, 500);

            checking.Deposit(500);

            Assert.AreEqual(1000, checking.Amount);
        }

        [TestMethod]
        public void Checking_Account_Interest_Returns10500After10000At5Percent()
        {
            var checking = new Checking(2, 10000);

            decimal interestInOneYear = checking.ReturnInterest();

            Assert.AreEqual(10500, interestInOneYear);
        }

        [TestMethod]
        public void Premium_Account_Interest_Returns10600After10000At5Percent()
        {
            var premium = new Premium(2, 10000);

            decimal interestInOneYear = premium.ReturnInterest();

            Assert.AreEqual(10600, interestInOneYear);
        }

        [TestMethod]
        public void Checking_Returns5000AfterTransfer()
        {
            var checking = new Checking(1, 2500);
            var premium = new Premium(2, 7500);

            Account.TransferToChecking(checking, premium, 2500);

            Assert.AreEqual(5000, checking.Amount);
        }

        [TestMethod]
        public void Premium_Returns10000AfterTransfer()
        {
            var premium = new Premium(3, 9000);
            var checking = new Checking(4, 2000);

            Account.TransferToPremium(checking, premium, 1000);

            Assert.AreEqual(10000, premium.Amount);
        }
    }
}