using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BigBucksBank;

namespace UnitTestProject1
{
    [TestClass]
    public class BankTest
    {
        [TestMethod]
        public void TestConstructor()
        {
            // arrange
            Account account;

            // set
            account = new Account("Jeffrey");

            //assert 
            Assert.AreEqual(0, account.Balance);
            Assert.AreEqual("Jeffrey", account.Name);
        }

        [TestMethod]
        public void TestConstructor2()
        {
            // arrange
            Account account;

            // set
            account = new Account("Jeffrey", 12);

            //assert 
            Assert.AreEqual(12, account.Balance);
            Assert.AreEqual("Jeffrey", account.Name);
        }

        [TestMethod]
        public void TestWithdrawSucces()
        {
            // arrange
            Account account = new Account("Jeffrey", 12);

            // set
            account.Withdraw(8);

            // set
            Assert.AreEqual(4, account.Balance);
        }

        [TestMethod]
        [ExpectedException(typeof(NotEnoughCreditException))]
        public void TestNotEnoughCreditException()
        {
            // arrange
            Account account = new Account("Jeffrey", 12);

            // set
            account.Withdraw(1018);
        }

        [TestMethod]
        public void Deposit()
        {
            // arrange
            Account account = new Account("Jeffrey", 12);

            // set
            account.Deposit(8);

            // set
            Assert.AreEqual(20, account.Balance);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void DepositNegativeValue()
        {
            // arrange
            Account account = new Account("Jeffrey", 12);

            // set
            account.Deposit(-8);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void DepositOverFlowExecption()
        {
            // arrange
            Account account = new Account("Jeffrey", 12);

            // set
            account.Deposit(decimal.MaxValue);
        }


    }
}
