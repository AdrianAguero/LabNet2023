using ManejoExepciones;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DividirPorCeroTest()
        {
            //arrange
            int divisor = 5;
            //act
            divisor.DividirPorCero();
        }

        [TestMethod()]
        public void DividirTest()
        {
            //arrange
            int num1 = 4;
            int num2 = 2;
            decimal resultadoEsperado = 2;
            //act
            decimal resultadoActual = Logic.Dividir(num1, num2);
            //assert
            Assert.AreEqual(resultadoEsperado, resultadoActual);
        }


        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DividirExceptionTest()
        {
            //arrange
            int dividendo = 4;
            int divisor = 0;
            //act
            Logic.Dividir(dividendo, divisor);
        }
    }
}
