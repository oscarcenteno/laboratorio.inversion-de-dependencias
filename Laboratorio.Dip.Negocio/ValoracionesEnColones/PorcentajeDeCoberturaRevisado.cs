namespace Laboratorio.Dip.Negocio.ValoracionesEnColones
{
    public class PorcentajeDeCoberturaRevisado
    {
        private decimal elPorcentajeCobertura;
        private decimal losDiasAlVencimiento;
        private int losDiasMinimosAlVencimientoDelEmisor;

        public PorcentajeDeCoberturaRevisado(DatosDelISINEnColones losDatos)
        {
            losDiasAlVencimiento = ObtengaLosDiasAlVencimiento(losDatos);
            losDiasMinimosAlVencimientoDelEmisor = losDatos.DiasMinimosAlVencimientoDelEmisor;
            elPorcentajeCobertura = losDatos.PorcentajeCobertura;
        }

        private static decimal ObtengaLosDiasAlVencimiento(DatosDelISINEnColones losDatos)
        {
            return new DiasAlVencimiento(losDatos).ComoNumero();
        }

        public decimal ComoNumero()
        {
            // Si no cumple los días mínimos, el porcentaje de cobertura es cero
            if (losDiasAlVencimiento < losDiasMinimosAlVencimientoDelEmisor)
                return 0;
            else
                return elPorcentajeCobertura;
        }
    }
}