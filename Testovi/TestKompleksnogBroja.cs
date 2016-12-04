using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp;

namespace Testovi
{
    [TestClass]
    public class TestKompleksnogBroja
    {
        [TestMethod]
        public void KompleksniBroj_BinarniOperatorPlusDajeZbrojDvaKompleksnaBroja()
        {
            KompleksniBroj kb1 = new KompleksniBroj(1, 2);
            KompleksniBroj kb2 = new KompleksniBroj(3, 5);
            Assert.AreEqual(new KompleksniBroj(4, 7), kb1 + kb2);
        }

        [TestMethod]
        public void KompleksniBroj_BinarniOperatorMinusDajeRazlikuDvaKompleksnaBroja()
        {
            KompleksniBroj kb1 = new KompleksniBroj(1, 2);
            KompleksniBroj kb2 = new KompleksniBroj(3, 5);
            Assert.AreEqual(new KompleksniBroj(-2, -3), kb1 - kb2);
        }

        [TestMethod]
        public void KompleksniBroj_UnarniOperatorMinusVraćaKompleksniBrojSPromijenenimPredznacima()
        {
            KompleksniBroj kb1 = new KompleksniBroj(1, 2);
            Assert.AreEqual(new KompleksniBroj(-1, -2), -kb1);
        }
    }
}
