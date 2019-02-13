using Microsoft.VisualStudio.TestTools.UnitTesting;
using PencilKata;

namespace PencilKataTest
{
    [TestClass]
    public class EraserTest
    {
        [TestMethod]
        public void WhenFinderMethodCalledReturnsLastIndexOfParameterString()
        {
            Pencil pencil = new Pencil(20, 20);
            Paper paper = new Paper();
            Eraser eraser = new Eraser(20);

            pencil.Write("Hello World!", paper);

            Assert.AreEqual(6, eraser.Finder("World", paper));
        }

        [TestMethod]
        public void WhenEraseMethodCalledRemovesLastInstanceOfParameterString()
        {
            Pencil pencil = new Pencil(20, 20);
            Paper paper = new Paper();
            Eraser eraser = new Eraser(20);

            pencil.Write("Hello World!", paper);
            eraser.Erase("World", paper);

            Assert.AreEqual("Hello      !", paper.Text);
        }
        
        [TestMethod]
        public void WhenEraseMethodCalledEraserDurabilityDecreasesByOneForNonSpaceCharacters()
        {
            Pencil pencil = new Pencil(20, 5);
            Paper paper = new Paper();
            Eraser eraser = new Eraser(20);

            pencil.Write("hello world!", paper);
            eraser.Erase("hello world!", paper);
            
            Assert.AreEqual(9, eraser.CurrentDurability);
        }

        [TestMethod]
        public void WhenCurrentDurabilityIsZeroEraseMethodWillStopErasing()
        {
            Pencil pencil = new Pencil(20, 5);
            Paper paper = new Paper();
            Eraser eraser = new Eraser(5);

            pencil.Write("hello world!", paper);
            eraser.Erase("hello world!", paper);

            Assert.AreEqual("hello w     ", paper.Text);
        }
        
        
    }
}