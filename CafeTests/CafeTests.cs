using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cafe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe.Tests
{
    [TestClass()]
    public class CafeTests
    {
        [TestMethod()]
        public void PrisTestKaffe()
        {
            //Arrange
            var Cafe = new ();
            //Act
            int pris = Cafe.Pris();
            //Assert
            Assert.AreEqual(20, pris);
        }

        [TestMethod()]
        public void StyrkeTestKaffe()
        {
            //Arrange
            var cafe = new Kaffe();
            //Act
            string Styrke = cafe.Styrke();
            //Assert
            Assert.AreEqual("stærk", Styrke);
        }
    }
}