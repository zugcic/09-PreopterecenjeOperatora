using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestStrukturaDatum
    {
        [TestMethod]
        public void StrukturaDatum_PreinkrementUvećavaRezultatIPridruženuVarijablu()
        {
            StrukturaDatum sd = new StrukturaDatum(2015, 12, 31);

            StrukturaDatum sdPrefix = ++sd;
            Assert.AreEqual(new StrukturaDatum(2016, 1, 1), sd);
            Assert.AreEqual(new StrukturaDatum(2016, 1, 1), sdPrefix);
        }

        [TestMethod]
        public void StrukturaDatum_PostinkrementUvećavaRezultatAliNeIPridruženuVarijablu()
        {
            StrukturaDatum sd = new StrukturaDatum(2015, 12, 31);

            StrukturaDatum sdPostfix = sd++;
            Assert.AreEqual(new StrukturaDatum(2016, 1, 1), sd);
            Assert.AreEqual(new StrukturaDatum(2015, 12, 31), sdPostfix);
        }
    }
}
