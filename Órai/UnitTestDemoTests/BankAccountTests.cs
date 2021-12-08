using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDemo.Tests
{
    [TestClass()]
    public class BankAccountTests
    {
        [TestMethod()]
        // Az alábbit átírja
        //public void BankAccountTest()
        //{
        //    Assert.Fail();
        //}
        public void TestExceptionCase()
        {
            BankAccount bank = new BankAccount("Éva", 0);
            try
            {
                bank.Kivet(2);
            }
            catch (ArgumentOutOfRangeException e)
            {

                StringAssert.Contains(e.Message, "egyenleg <= 0 vagy kivét > egyenleg");
                return;
            }
            catch (Exception e)
            {

                StringAssert.Contains(e.Message, "egyenleg = 0");
                return;
            }

            Assert.Fail("Nem volt hiba");
        }

        [TestMethod()]
        public void TestKivetCase()
        {
            BankAccount bank = new BankAccount("Éva", 2);
            bank.Kivet(2);
            Assert.AreEqual(0, bank.Egyenleg);
        }

        [TestMethod()]
        public void TestBetetCase()
        {
            BankAccount bank = new BankAccount("Éva", 2);
            bank.Betet(2);
            Assert.AreEqual(0, bank.Egyenleg);
        }

        [TestMethod()]
        public void TestBetetKivetCase()
        {
            BankAccount bank = new BankAccount("Éva", 2);
            bank.Betet(2);
            bank.Kivet(2);
            Assert.AreEqual(2, bank.Egyenleg);
        }
    }
}