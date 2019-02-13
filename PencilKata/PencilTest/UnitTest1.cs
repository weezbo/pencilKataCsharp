using Microsoft.VisualStudio.TestTools.UnitTesting;
using PencilKata;

namespace PencilTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WhenWriteMethodPassedAStringItReturnsString()
        {
            Pencil pencil = new Pencil();
            
            Assert.AreEqual("Hello World!", pencil.Write("Hello World!"));
        }
    }
}