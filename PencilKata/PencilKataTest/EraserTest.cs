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
            Eraser eraser = new Eraser();

            pencil.Write("Hello World!", paper);

            Assert.AreEqual(6, eraser.Finder("World", paper));
        }

        [TestMethod]
        public void WhenEraseMethodCalledRemovesLastInstanceOfParameterString()
        {
            Pencil pencil = new Pencil(20, 20);
            Paper paper = new Paper();
            Eraser eraser = new Eraser();

            pencil.Write("Hello World!", paper);
            eraser.Erase("World", paper);

            Assert.AreEqual("Hello      !", paper.Text);
        }
        
        
    }
}