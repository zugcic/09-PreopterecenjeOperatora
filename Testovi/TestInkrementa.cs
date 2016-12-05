using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestInkrementa
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

        [TestMethod]
        public void KlasaDatum_PreinkrementUvećavaRezultatIPridruženuVarijablu()
        {
            KlasaDatum kd = new KlasaDatum(2016, 2, 28);

            KlasaDatum kd2 = ++kd;
            Assert.AreEqual(new KlasaDatum(2016, 2, 29), kd);
            Assert.AreEqual(new KlasaDatum(2016, 2, 29), kd2);
        }

        [TestMethod]
        public void KlasaDatum_PostinkrementUvećavaRezultatIPridruženuVarijablu()
        {
            KlasaDatum kd = new KlasaDatum(2016, 2, 29);

            KlasaDatum kd2 = kd++;
            Assert.AreEqual(new KlasaDatum(2016, 3, 1), kd);
            Assert.AreEqual(new KlasaDatum(2016, 3, 1), kd2);
        }
    }
}
