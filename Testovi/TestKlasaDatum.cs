using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.Testovi
{
    [TestClass]
    public class TestKlasaDatum
    {
        [TestMethod]
        public void KlasaDatum_PreinkrementUvećavaRezultatIPridruženuVarijablu()
        {
            KlasaDatum kd = new KlasaDatum(2016, 2, 28);

            KlasaDatum kd2 = ++kd;
            Assert.AreEqual(new KlasaDatum(2016, 2, 29), kd);
            Assert.AreEqual(new KlasaDatum(2016, 2, 29), kd2);

            KlasaDatum kd3 = kd++;
            Assert.AreEqual(new KlasaDatum(2016, 3, 1), kd);
            Assert.AreEqual(new KlasaDatum(2016, 3, 1), kd2);
            Assert.AreEqual(new KlasaDatum(2016, 3, 1), kd3);
        }
    }
}
