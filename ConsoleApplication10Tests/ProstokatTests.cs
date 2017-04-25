using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10.Tests
{
    [TestClass()]
    public class ProstokatTests
    {
        [TestMethod()]
        public void MetodaTest()
        {
            int a = 2;
            int b = 3;
            
            Prostokat c = new Prostokat();
            int owyn = 6;
            int wyn = a * b;
            
            Assert.AreEqual(owyn, wyn); //assert
        }
    }

}