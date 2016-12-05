using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestEksplicitnePretvorbe
    {
        [TestMethod]
        public void Racionalni_EksplicitnaPretvorbaZaDvijeTrećineUDoubleDajeDvijeTrećine()
        {
            Racionalni rac = new Racionalni(2, 3);
            Assert.AreEqual(2.0 / 3.0, (double)rac);
        }

        [TestMethod]
        public void Racionalni_EksplicitnaPretvorbaZaDvijeTrećineULongDaje0()
        {
            Racionalni rac = new Racionalni(2, 3);
            Assert.AreEqual(2L / 3L, (long)rac);
        }
    }
}
