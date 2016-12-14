using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laboratorio.Dip.Negocio.ValoracionesEnColones;
using System;

namespace Laboratorio.Dip.Negocio.UnitTests.ValoracionesEnColones.PorcentajeDeCoberturaRevisado_Tests
{
    [TestClass]
    public class ComoNumero_Tests
    {
        private decimal elResultadoEsperado;
        private decimal elResultadoObtenido;
        private DatosDelISINEnColones losDatos;

        [TestMethod]
        public void ComoNumero_EnColonesYCumpleLosDiasMinimos_UsaElPorcentajeRecibido() 
        {
            elResultadoEsperado = 0.8M;

            InicialiceElEscenarioCumpleLosDiasMinimos();
            elResultadoObtenido = new PorcentajeDeCoberturaRevisado(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        private void InicialiceElEscenarioCumpleLosDiasMinimos()
        {
            losDatos = new DatosDelISINEnColones();
            losDatos.FechaActual = new DateTime(2016, 1, 1);
            losDatos.FechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6); ;
            losDatos.DiasMinimosAlVencimientoDelEmisor = 7;
            losDatos.PorcentajeCobertura = 0.8M;
        }

        [TestMethod]
        public void ComoNumero_EnColonesYNoCumpleLosDiasMinimos_Cero()
        {
            elResultadoEsperado = 0;

            InicialiceElEscenarioNoCumpleLosDiasMinimos();
            elResultadoObtenido = new PorcentajeDeCoberturaRevisado(losDatos).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }

        private void InicialiceElEscenarioNoCumpleLosDiasMinimos()
        {
            losDatos = new DatosDelISINEnColones();
            losDatos.FechaActual = new DateTime(2016, 1, 1);
            losDatos.FechaDeVencimientoDelValorOficial = new DateTime(2016, 1, 7); ;
            losDatos.DiasMinimosAlVencimientoDelEmisor = 7;
            losDatos.PorcentajeCobertura = 0.8M;
        }
    }
}