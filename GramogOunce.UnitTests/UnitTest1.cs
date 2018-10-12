using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOClassLibrary;

namespace GramogOunce.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        double konstant = 28.34952;

        [TestMethod]

        public void ConvertToGramHelTal()
        {
            double ounce = 1;
            double eq = konstant * ounce;
            var convertToGram = new Methods();
            double ctGram = convertToGram.ConvertToGram(ounce);
            Assert.AreEqual(eq, ctGram, 0.0001);
        }

        [TestMethod]

        public void ConvertToGramKommaTal()
        {
            double ounce = 1.1;
            double eq = konstant * ounce;
            var convertToGram = new Methods();
            double ctGram = convertToGram.ConvertToGram(ounce);
            Assert.AreEqual(eq, ctGram, 0.0001);
        }

        [TestMethod]

        public void ConvertToOunceHelTal()
        {
            double gram = 1;
            double eq = gram / konstant;
            var convertToOunce = new Methods();
            double ctOunce = convertToOunce.ConvertToOunce(gram);
            Assert.AreEqual(eq, ctOunce, 0.0001);
        }

        [TestMethod] //

        public void ConvertToOunceKommaTal()
        {
            double gram = 1.1;
            double eq = gram / konstant;
            var convertToOunce = new Methods();
            double ctOunce = convertToOunce.ConvertToOunce(gram);
            Assert.AreEqual(eq, ctOunce, 0.0001);
        }
    }
}
