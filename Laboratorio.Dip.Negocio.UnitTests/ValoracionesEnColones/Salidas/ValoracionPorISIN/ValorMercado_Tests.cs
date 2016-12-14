using Laboratorio.Dip.Negocio.ValoracionesEnColones;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Laboratorio.Dip.Negocio.UnitTests.ValoracionesEnColones.ValoracionPorISIN_Tests
{
    [TestClass]
    public class ValorDeMercado_Tests : Escenarios
    {
        private decimal elResultadoEsperado;
        private ValoracionPorISIN laValoracion;
        private decimal elResultadoObtenido;

        [TestMethod]
        public void ValorDeMercado_EnColones_UsaMontoNominalDelSaldo()
        {
            elResultadoEsperado = 2862400;

            laValoracion = UnaValoracionEnColonesYCumpleLosDiasMinimos();
            elResultadoObtenido = laValoracion.ValorDeMercado;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

    }
}