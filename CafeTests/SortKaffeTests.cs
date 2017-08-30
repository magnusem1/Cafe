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
    public class SortKaffeTests
    {
        //Når vi giver 20 kr i rabat, burde den kalde ArgumentException
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void PrisTestForMegetRabat()
        {
            //Arrange
            var SortKaffe = new SortKaffe(20);
            //Act
            int pris = SortKaffe.Pris();
            

        }
    }
}