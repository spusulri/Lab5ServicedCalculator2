using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCalculations
{
    [TestClass]
    public class UnitTest1
    {
        private Calculator.Calculator_ASMXSoapClient calcRef;
        [TestMethod]
        public void TestAdd() {
            calcRef = new Calculator.Calculator_ASMXSoapClient();
            double d = calcRef.Add(2.0, 2.0);
            Assert.AreEqual(d, 4.0);
        


        
        }

        /* public void TestSquareRoot()
         {
             calcRef = new Calculator.Calculator_ASMXSoapClient();
             double d = calcRef.Sqrt(81.0);
             Assert.AreEqual(d, 9);


         }*/
       /* [TestMethod]
        public void TestHalve()
        {
            calcRef=  new Calculator.Calculator_ASMXSoapClient();
            int divi = 2;
            double d = calcRef.Divide(12, divi);
            Assert.AreEqual(d, 6);

        }
        [TestMethod]
        public void TestQuarter()
        {
            calcRef = new Calculator.Calculator_ASMXSoapClient();
            int divi = 4;
            double d = calcRef.Divide(12, divi);
            Assert.AreEqual(d, 3);
        }*/
    }
}
