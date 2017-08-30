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
    public class LatteTests
    {
        [TestMethod()]
        public void PrisTest()
        {
            //Arrange
            Latte Latte = new Latte();
            //Act
            int pris = Latte.Pris();
            //Assert
            Assert.AreEqual(40, pris);
        }
    }
}