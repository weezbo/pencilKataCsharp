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
            Pencil pencil = new Pencil(20);
            Paper paper = new Paper();
            pencil.Write("Hello World", paper);
            Assert.AreEqual("Hello World", paper.Text);
        }
        
        [TestMethod]
        public void WhenPencilWritesMorePaperStoresAdditionalWriting()
        {
            Pencil pencil = new Pencil(20);
            Paper paper = new Paper();
            pencil.Write("Hello World", paper);
            pencil.Write(" How are you", paper);
            Assert.AreEqual("Hello World" + " How are you", paper.Text);
        }


    }
    
}