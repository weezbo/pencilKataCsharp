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
            Pencil pencil = new Pencil(20, 5);
            Paper paper = new Paper();
            
            Assert.AreEqual("Hello World!", pencil.Write("Hello World!", paper));
        }

        [TestMethod]
        public void WhenWriteMethodCalledPencilDurabilityDecreasesByOneForNonSpaceCharacters()
        {
            Pencil pencil = new Pencil(20, 5);
            Paper paper = new Paper();

            pencil.Write("hello world!", paper);
            
            Assert.AreEqual(9, pencil.CurrentDurability);
        }
        
        [TestMethod]
        public void WhenWriteMethodCalledDurabilityDecreasesByTwoForCapitals()
        {
            Pencil pencil = new Pencil(20, 5);
            Paper paper = new Paper();

            pencil.Write("Hello World!", paper);
            
            Assert.AreEqual(7, pencil.CurrentDurability);
        }
        
        [TestMethod]
        public void WhenPointDurabilityReachesZeroOnlySpacesAreWritten()
        {
            Pencil stubby = new Pencil(4, 5);
            Paper paper = new Paper();

            stubby.Write("Text", paper);
            
            Assert.AreEqual("Tex ", paper.Text);
        }

        [TestMethod]
        public void WhenSharpenMethodCalledDurabilityIsSetToOriginalDurability()
        {
            Pencil pencil = new Pencil(10, 5);
            Paper paper = new Paper();

            pencil.Write("Text", paper);
            pencil.Sharpen();
            
            Assert.AreEqual(pencil.OriginalDurability, pencil.CurrentDurability);
        }
        
        [TestMethod]
        public void WhenSharpenMethodCalledLengthOfPencilReducesOneUnit()
        {
            Pencil pencil = new Pencil(10, 5);
            Paper paper = new Paper();

            pencil.Write("Text", paper);
            pencil.Sharpen();
   
            
            Assert.AreEqual(4, pencil.Length);
        }
        
        [TestMethod]
        public void SharpenMethodDoesNotExecuteIfLength0()
        {
            Pencil pencil = new Pencil(10, 0);
            Paper paper = new Paper();

            pencil.Write("Text", paper);
            pencil.Sharpen();
  
            
            Assert.AreEqual(5, pencil.CurrentDurability);
        }
        
    }
}