using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeNumberTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(PrimeNumber.Prime.isPrimeNumber(2));

        }
        [TestMethod]
        public void TestMethod2()
        {
         
            Assert.IsTrue(PrimeNumber.Prime.isPrimeNumber(3));
        
        }
        [TestMethod]
        public void TestMethod3()
        {
        
            Assert.IsTrue(PrimeNumber.Prime.isPrimeNumber(4));

        }
    }
}
