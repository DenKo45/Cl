﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMatch;

namespace UT_MyMath
{
    [TestClass]
    public class UT_KvUr
    {
        [TestMethod]
        public void Test_1__2_6_9()
        {
            int a = 2, b = 6, c = 9;
            string actError, expError ="Нет корней";
            double[] expResult = new double[0];
            double[] actResult = KvUr.Matching(a, b, c, out actError);
            Assert.AreEqual(expError, actError, "Полученное сообщение (" + actError + ") не совпадает с ожидаемым (" + expError + ")");
            Assert.AreEqual(expResult.Length, actResult.Length);
            for (int i = 0; i < expResult.Length; i++)
                Assert.AreEqual(expResult[i], actResult[i]);
        }
    }
}
