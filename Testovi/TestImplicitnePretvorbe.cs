using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestImplicitnePretvorbe
    {
        [TestMethod]
        public void Racionalni_ImplicitnaPretvorbaIzJedneDesetineDajeBrojSBrojnikom1Nazivnikom10()
        {
            Racionalni rac = 0.1;
            Assert.AreEqual(1, rac.Brojnik);
            Assert.AreEqual(10, rac.Nazivnik);
        }

        [TestMethod]
        public void Racionalni_ImplicitnaPretvorbaIzDvaDajeBrojSBrojnikom2Nazivnikom1()
        {
            Racionalni rac = 2;
            Assert.AreEqual(2, rac.Brojnik);
            Assert.AreEqual(1, rac.Nazivnik);
        }
    }
}
