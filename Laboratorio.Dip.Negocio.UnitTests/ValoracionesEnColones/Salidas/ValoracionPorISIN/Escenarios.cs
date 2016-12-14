using Laboratorio.Dip.Negocio.ValoracionesEnColones;
using System;

namespace Laboratorio.Dip.Negocio.UnitTests.ValoracionesEnColones.ValoracionPorISIN_Tests
{
    public class Escenarios
    {
        private DatosDelISINEnColones losDatos;

        public ValoracionPorISIN UnaValoracionEnColonesYCumpleLosDiasMinimos()
        {
            losDatos = new DatosDelISINEnColones();
            losDatos.ISIN = "HDA000000000001";
            losDatos.FechaActual = new DateTime(2016, 1, 1);
            losDatos.FechaDeVencimientoDelValorOficial = new DateTime(2016, 6, 6); ;
            losDatos.DiasMinimosAlVencimientoDelEmisor = 7;
            losDatos.PorcentajeCobertura = 0.8M;
            losDatos.PrecioLimpioDelVectorDePrecios = 80;
            losDatos.MontoNominalDelSaldo = 3578000;

            return new ValoracionPorISIN(losDatos);
        }

        public ValoracionPorISIN InicialiceUnaValoracionEnColonesYNoCumpleLosDiasMinimos()
        {
            losDatos = new DatosDelISINEnColones();
            losDatos.ISIN = "HDA000000000001";
            losDatos.FechaActual = new DateTime(2016, 1, 1);
            losDatos.FechaDeVencimientoDelValorOficial = new DateTime(2016, 1, 7); ;
            losDatos.DiasMinimosAlVencimientoDelEmisor = 7;
            losDatos.PorcentajeCobertura = 0.8M;
            losDatos.PrecioLimpioDelVectorDePrecios = 80;
            losDatos.MontoNominalDelSaldo = 3578000;

            return new ValoracionPorISIN(losDatos);
        }
    }
}