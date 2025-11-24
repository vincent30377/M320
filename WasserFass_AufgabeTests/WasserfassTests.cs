using Microsoft.VisualStudio.TestTools.UnitTesting;
using WasserFass_Aufgabe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WasserFass_Aufgabe.Tests
{
    [TestClass]
    public sealed class WasserfassTest
    {
        [TestMethod]
        public void Befuellen_Normal()
        {
            // Arrange
            Wasserfass fass = new Wasserfass(100);
            // Act
            fass.Befuellen(40);
            // Assert
            Assert.AreEqual(40, fass.Fuellstand);
        }
        [TestMethod]
        public void Befuellen_ÜberKapazitaet()
        {
            // Arrange
            Wasserfass fass = new Wasserfass(100);
            // Act
            fass.Befuellen(150);
            // Assert
            Assert.AreEqual(100, fass.Fuellstand);
        }
        [TestMethod]
        public void Befuellen_Negativ()
        {
            // Arrange
            Wasserfass fass = new Wasserfass(100);
            // Act
            fass.Befuellen(-100);
            // Assert
            Assert.AreEqual(0, fass.Fuellstand);
        }
        [TestMethod]
        public void Entnehmen_Normal()
        {
            // Arrange
            Wasserfass fass = new Wasserfass(100);
            fass.Befuellen(80);
            // Act
            fass.Entnehmen(30);
            // Assert
            Assert.AreEqual(50, fass.Fuellstand);
        }
        [TestMethod]
        public void Entnehmen_UnterMinimal()
        {
            // Arrange
            Wasserfass fass = new Wasserfass(100);
            fass.Befuellen(20);
            // Act
            fass.Entnehmen(50);
            // Assert
            Assert.AreEqual(0, fass.Fuellstand);
        }
        [TestMethod]
        public void Entnehmen_Null()
        {
            // Arrange
            Wasserfass fass = new Wasserfass(100);
            fass.Befuellen(50);
            // Act
            fass.Entnehmen(0);
            int nullEntleert = fass.Fuellstand;
            // Assert
            Assert.AreEqual(50, nullEntleert);
        }
        [TestMethod]
        public void Entleeren_Test()
        {
            // Arrange
            Wasserfass fass = new Wasserfass(100);
            fass.Befuellen(60);
            // Act
            fass.Entleeren();
            // Assert
            Assert.AreEqual(0, fass.Fuellstand);
        }
        [TestMethod]
        public void Entleeren_Test2()
        {
            // Arrange
            Wasserfass fass = new Wasserfass(100);
            fass.Befuellen(100);
            // Act
            fass.Entleeren();
            // Assert
            Assert.AreEqual(0, fass.Fuellstand);
        }
        [TestMethod]
        public void Entleeren_LeeresFass()
        {
            // Arrange
            Wasserfass fass = new Wasserfass(100);
            fass.Befuellen(0);
            // Act
            fass.Entleeren();
            // Assert
            Assert.AreEqual(0, fass.Fuellstand);
        }
    }
}