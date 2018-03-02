

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Infrastructure.Data.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DeveDividir()
        {            
           int resultado = 2/4;
           int ss =0;
           Assert.AreEqual(2,resultado);
        }
    }
}
