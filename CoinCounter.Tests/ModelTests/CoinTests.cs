using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinCounter.Models;
using System;

namespace CoinCounter.Tests
{
    [TestClass]
    public class CoinTests //: IDisposable
    {
        // public void Dispose()
        // {
        //     Amount.ClearAll();
        // }
        [TestMethod]
        public void CoinCounter_CreatesInstanceOfCoin_Coin()
        {
            Amount newAmount = new Amount(3);
            Assert.AreEqual(typeof(Amount), newAmount.GetType());
        }

        [TestMethod]
        public void CoinCounter_ChecksInstaceOfInt_TrueOrFalse()
        {
            int value = 3;
            Amount newAmount = new Amount(value);
            int result = newAmount.Value;
            Assert.AreEqual(value, result);
        }

        [TestMethod]
        public void NumberToQuarterToDivide_DivideInstanceByIncrementAmount_Remainder() 
        {
            int value = 85; //value in cents 
            Amount newAmount = new Amount(value);
            int result = newAmount.NumberToQuarterToDivide(value);
            Assert.AreEqual(value % 25, result);
        }
   
       [TestMethod]
        public void NumberToDimeToDivide_DivideInstanceByIncrementAmount_Remainder() 
        {
            int value = 10; //value in cents 
            Amount newAmount = new Amount(value);
            int result = newAmount.NumberToDimeToDivide(value);
            Assert.AreEqual(value % 10, result);

        }
       [TestMethod]
        public void NumberToNickelToDivide_DivideInstanceByIncrementAmount_Remainder() 
        {
            int value = 24; //value in cents 
            Amount newAmount = new Amount(value);
            int result = newAmount.NumberToNickelToDivide(value);
            Assert.AreEqual(value % 5, result);
        }
        [TestMethod]
        public void NumberToPennies_ReturnFinalInstanceAsPennies_RemainderOfCentsToPenny()
        {
            int value = 3; //value in cents
            Amount newAmount = new Amount(value);
            int result = newAmount.NumberToPennies(value);
            Assert.AreEqual(value, result);
        }
    }
}