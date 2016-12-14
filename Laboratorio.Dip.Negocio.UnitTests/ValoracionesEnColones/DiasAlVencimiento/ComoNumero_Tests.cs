using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laboratorio.Dip.Negocio.ValoracionesEnColones;
using System;

namespace Laboratorio.Dip.Negocio.UnitTests.ValoracionesEnColones.DiasAlVencimiento_Tests
{
    [TestClass]
    public class ComoNumero_Tests
    {
        private decimal elResultadoEsperado;
        private decimal elResultadoObtenido;
        private DatosDelISINEnColones losDatos;

        [TestMethod]
        public void ComoNumero_DosFechas_LosDiasDeDiferencia()
        {
            elResultadoEsperado = 221;

            InicialiceLasFechas();
            elResultadoObtenido = new DiasAlVencimiento(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        private void InicialiceLasFechas()
        {
            losDatos = new DatosDelISINEnColones();
            losDatos.FechaDeVencimientoDelValorOficial = new DateTime(2016, 10, 10);
            losDatos.FechaActual = new DateTime(2016, 3, 3);
        }
    }
}