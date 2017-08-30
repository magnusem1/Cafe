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
        public void PrisTestSortKaffe()
        {
            //Arrange
            var SortKaffe = new SortKaffe();
            //Act
            int pris = SortKaffe.Pris();
            //Assert
            Assert.AreEqual(20, pris);
        }

        [TestMethod()]
        public void StyrkeTestSortKaffe()
        {
            //Arrange
            var cafe = new SortKaffe();
            //Act
            string Styrke = cafe.Styrke();
            //Assert
            Assert.AreEqual("stærk", Styrke);
        }

        [TestMethod()]
        public void TestKaffeListe()
        {
            var kaffeliste = new List<IMælk>();

            var Cortado = new Cortado();
            var Latte = new Latte();
            var SortKaffe = new SortKaffe();
            kaffeliste.Add(Cortado);
            kaffeliste.Add(Latte);

            foreach (var kaffeitem in kaffeliste)
            {
                if (kaffeitem is Cortado)
                {
                    var localCortado = kaffeitem as Cortado;
                }
                kaffeitem.MlMælk();
            }
        }
    }
    }
}