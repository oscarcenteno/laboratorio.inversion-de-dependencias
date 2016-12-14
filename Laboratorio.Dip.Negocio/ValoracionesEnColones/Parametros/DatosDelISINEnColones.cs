﻿using System;

namespace Laboratorio.Dip.Negocio.ValoracionesEnColones
{
    public class DatosDelISINEnColones
    {
        public string ISIN { get; set; }
        public DateTime FechaActual { get; set; }
        public DateTime FechaDeVencimientoDelValorOficial { get; set; }
        public int DiasMinimosAlVencimientoDelEmisor { get; set; }
        public decimal PorcentajeCobertura { get; set; }
        public decimal PrecioLimpioDelVectorDePrecios { get; set; }
        public decimal MontoNominalDelSaldo { get; set; }
        public TimeSpan TiempoAlVencimiento
        {
            get
            {
                return FechaDeVencimientoDelValorOficial - FechaActual;
            }
        }

        public decimal ValorDeMercado
        {
            get
            {
                return MontoNominalDelSaldo * (PrecioLimpioDelVectorDePrecios / 100);
            }
        }
    }
}