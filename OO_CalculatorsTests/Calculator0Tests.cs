using Microsoft.VisualStudio.TestTools.UnitTesting;
using OO_Calculators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Calculators.Tests
{
    [TestClass()]
    public class Calculator0Tests
    {
        [TestMethod()]
        public void AddTest()
        {
            Calculator0 calculator = new Calculator0();

            int summe = calculator.Add(2, 3);

            Assert.AreEqual(5, summe);
        }
        public void AddTest00()
        {
            Calculator0 calculator = new Calculator0();

            int summe = calculator.Add(0, 0);

            Assert.AreEqual(0, summe);
        }
        public void AddTest02()
        {
            Calculator0 calculator = new Calculator0();

            int summe = calculator.Add(0, 2);

            Assert.AreEqual(2, summe);
        }
        public void AddTest43()
        {
            Calculator0 calculator = new Calculator0();

            int summe = calculator.Add(-4, 3);

            Assert.AreEqual(1, summe);
        }
    }
}