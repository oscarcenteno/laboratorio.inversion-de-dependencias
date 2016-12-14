using Laboratorio.Dip.Negocio.ValoracionesEnColones;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Laboratorio.Dip.Negocio.UnitTests.ValoracionesEnColones.ValoracionPorISIN_Tests
{
    [TestClass]
    public class AporteDeGarantia_Tests : Escenarios
    {
        private decimal elResultadoEsperado;
        private ValoracionPorISIN laValoracion;
        private decimal elResultadoObtenido;

        [TestMethod]
        public void AporteDeGarantia_EnColonesYCumpleLosDiasMinimos_AporteCalculado()
        {
            elResultadoEsperado = 2289920;

            laValoracion = UnaValoracionEnColonesYCumpleLosDiasMinimos();
            elResultadoObtenido = laValoracion.AporteDeGarantia;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        [TestMethod]
        public void AporteDeGarantia_EnColonesYNoCumpleLosDiasMinimos_Cero()
        {
            elResultadoEsperado = 0;

            laValoracion = InicialiceUnaValoracionEnColonesYNoCumpleLosDiasMinimos();
            elResultadoObtenido = laValoracion.AporteDeGarantia;

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}