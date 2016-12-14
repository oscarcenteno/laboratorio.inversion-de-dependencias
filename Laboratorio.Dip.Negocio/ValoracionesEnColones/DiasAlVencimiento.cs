using System;

namespace Laboratorio.Dip.Negocio.ValoracionesEnColones
{
    public class DiasAlVencimiento
    {
        private TimeSpan elTiempoAlVencimiento;

        public DiasAlVencimiento(DatosDelISINEnColones losDatos)
        {
            elTiempoAlVencimiento = losDatos.TiempoAlVencimiento; 
        }

        public decimal ComoNumero()
        {
            return elTiempoAlVencimiento.Days;
        }
    }
}