using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculadoraEjemplo;


namespace ParcialSimpleTest
{
    [TestClass]
    public class ParcialSimpleTest
    {
        [TestMethod]
        public void SumarDosMasIgualCuatro()
        {
            CalculadoraSimple cal = new CalculadoraSimple();
            int resultado = cal.sumar(2, 2);
            Assert.AreEqual(4, resultado);
        }
        [TestMethod]
        public void SumarDosDigitosCaracter()
        {
            CalculadoraSimple cal = new CalculadoraSimple();
            int resultados = cal.suma("1", "1");
            Assert.AreEqual(2, resultados);
        }
        [TestMethod]
        public void RestaDosMenosUnoIgualUno()
        {
            CalculadoraSimple cal = new CalculadoraSimple();
            int resultado = cal.restar(2, 1);
            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void MultiplicarDosPorDosIgualCuatro()
        {
            CalculadoraSimple cal = new CalculadoraSimple();
            int resultado = cal.multiplicar(2, 2);
            Assert.AreEqual(4, resultado);
        }

        [TestMethod]
        public void DividirSeisVivididoEnDosTres()
        {
            CalculadoraSimple cal = new CalculadoraSimple();
            int resultado = cal.dividir(6, 2);
            Assert.AreEqual(3, resultado);

        }

        [TestMethod]
        public void SumarDigitoCadenasVacias()
        {
            CalculadoraSimple cal = new CalculadoraSimple();
            int resultado = cal.sumar("", "");
            Assert.AreEqual(0, resultado);

        }
        [TestMethod]
        public void Potencias()
        {
            CalculadoraSimple cal = new CalculadoraSimple();
            double resultado = cal.potencia(10, 2);
            Assert.AreEqual( 100,resultado);

        }

        [TestMethod]
        public void RaizCuadrada()
        {
            CalculadoraSimple cal = new CalculadoraSimple();
            double resultado = cal.raizcuadrada(9);
            Assert.AreEqual(3, resultado);

        }
        [TestMethod]
        public void Residuo()
        {
            CalculadoraSimple cal = new CalculadoraSimple();
            int resultado = cal.residuo(5,2);
            Assert.AreEqual(1, resultado);

        }
        [TestMethod]
        public void MultiplicarCero()
        {
            CalculadoraSimple cal = new CalculadoraSimple();
            int resultado = cal.multiplicarceroC(0, 4);
            Assert.AreEqual(0, resultado);

        }

    }
}
