using Microsoft.VisualStudio.TestTools.UnitTesting;
using PencilKata;

namespace PencilKataTest
{
    [TestClass]
    public class PencilTest
    {
        [TestMethod]
        public void WhenWriteMethodPassedAStringItReturnsString()
        {
            Pencil pencil = new Pencil(20);
            Paper paper = new Paper();
            
            Assert.AreEqual("Hello World!", pencil.Write("Hello World!", paper));
        }

        [TestMethod]
        public void WhenWriteMethodCalledPencilDurabilityDecreasesByOneForNonSpaceCharacters()
        {
            Pencil pencil = new Pencil(20);
            Paper paper = new Paper();

            pencil.Write("hello world!", paper);
            
            Assert.AreEqual(9, pencil.Durability);
        }
        
        [TestMethod]
        public void WhenWriteMethodCalledDurabilityDecreasesByTwoForCapitals()
        {
            Pencil pencil = new Pencil(20);
            Paper paper = new Paper();

            pencil.Write("Hello World!", paper);
            
            Assert.AreEqual(7, pencil.Durability);
        }
        
    }
}