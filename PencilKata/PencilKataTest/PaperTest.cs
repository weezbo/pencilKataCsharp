using Microsoft.VisualStudio.TestTools.UnitTesting;
using PencilKata;


namespace PencilKataTest
{
    [TestClass]
    public class PaperTest
    {
        [TestMethod]
        public void WhenPencilWritesPaperStoresWriting()
        {
            Pencil pencil = new Pencil(20, 5);
            Paper paper = new Paper();
            pencil.Write("Hello World", paper);
            Assert.AreEqual("Hello World", paper.Text);
        }
        
        [TestMethod]
        public void WhenPencilWritesMorePaperStoresAdditionalWriting()
        {
            Pencil pencil = new Pencil(500, 5);
            Paper paper = new Paper();
            pencil.Write("Hello World", paper);
            pencil.Write(" How are you", paper);
            Assert.AreEqual("Hello World" + " How are you", paper.Text);
        }

        [TestMethod]
        public void WhenEraserFinderMethodCalledLastEditPropertySetToStartIndex()
        {
            Pencil pencil = new Pencil(500, 5);
            Paper paper = new Paper();
            Eraser eraser = new Eraser(20);
            
            pencil.Write("Hello World", paper);
            eraser.Finder("World", paper);
            
            Assert.AreEqual(6, paper.LastEditIndex);
        }

        [TestMethod]
        public void WhenEditMethodCalledAddsCharsAtIndexWithoutCollision()
        {
            Pencil pencil = new Pencil(500, 5);
            Paper paper = new Paper();
            Eraser eraser = new Eraser(20);
            
            pencil.Write("Hello World", paper);
            eraser.Erase("World", paper);
            pencil.Edit("Howdy", paper);
            
            Assert.AreEqual("Hello Howdy", paper.Text);
        }

    }
    
}