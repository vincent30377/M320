using Microsoft.VisualStudio.TestTools.UnitTesting;
using WasserFass_Aufgabe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasserFass_Aufgabe.Tests
{
    [TestClass()]
    public class WasserfassTests
    {
        [TestMethod()]
        public void BefuellenTest()
        {
            fuellstand = 0;
            Wasserfass befuellen = new Wasserfass();

            int menge = Wasserfass.Befuellen(12);

            Assert.AreEqual(12, menge);
        }
    }
}