using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestKonstruktoraPretvorbe
    {
        [TestMethod]
        public void Racionalni_KonstruktorPretvorbeZaDvadesetPetDajeRacionalniBrojSBrojnikom25Nazivnikom1()
        {
            Racionalni rac = new Racionalni(25);
            Assert.AreEqual(25, rac.Brojnik);
            Assert.AreEqual(1, rac.Nazivnik);
        }

        [TestMethod]
        public void Racionalni_KonstruktorPretvorbeZaDvadesetPetStotninaDajeRacionalniBrojSBrojnikom1Nazivnikom4()
        {
            Racionalni rac = new Racionalni(0.25);
            Assert.AreEqual(1, rac.Brojnik);
            Assert.AreEqual(4, rac.Nazivnik);
        }

        [TestMethod]
        public void Racionalni_KonstruktorPretvorbeZaStodvadesetpettisućinaDajeRacionalniBrojSBrojnikom1Nazivnikom8()
        {
            Racionalni rac = new Racionalni(0.125);
            Assert.AreEqual(1, rac.Brojnik);
            Assert.AreEqual(8, rac.Nazivnik);
        }
    }
}
