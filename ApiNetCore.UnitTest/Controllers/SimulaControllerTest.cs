using ApiNetCore.Controllers;
using Moq;
using NUnit.Framework;
using System;

namespace ApiNetCoreUnitTest
{
    public class SimulaControllerTest
    {
        [Test]
        public void TestCalculaJurosController()
        {
            decimal valorInicial = 100;
            int tempo = 5;
            SimulaController simula = new SimulaController();
            string result = simula.GetCalculaJuros(valorInicial, tempo);
            Assert.IsNotNull(result);
        }

        [Test]
        public void TestTaxaJurosController()
        {
            SimulaController taxa = new SimulaController();
            double result = taxa.GetTaxaJuros();
            Assert.IsNotNull(result);
        }
    }
}
