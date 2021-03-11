using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MainConsoleApp;

namespace MainConsoleAppTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            CalculateSalary calculateSalary = new CalculateSalary();
            Assert.IsNotNull(calculateSalary);
           
        }        
    }
}
