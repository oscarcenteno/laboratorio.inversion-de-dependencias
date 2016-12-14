namespace Laboratorio.Dip.Negocio.ValoracionesEnColones
{
    public class ValoracionPorISIN
    {
        private decimal elValorDeMercado;
        private decimal elPorcentajeDeCoberturaRevisado;
        private string elISIN;

        public ValoracionPorISIN(DatosDelISINEnColones losDatos)
        {
            elISIN = losDatos.ISIN;
            elValorDeMercado = losDatos.ValorDeMercado;
            elPorcentajeDeCoberturaRevisado = new PorcentajeDeCoberturaRevisado(losDatos).ComoNumero();
        }

        public string ISIN
        {
            get
            {
                return elISIN;
            }
        }

        public decimal ValorDeMercado
        {
            get
            {
                return elValorDeMercado;
            }
        }

        public decimal PorcentajeCobertura
        {
            get
            {
                return elPorcentajeDeCoberturaRevisado;
            }
        }

        public decimal AporteDeGarantia
        {
            get
            {
                return elValorDeMercado * elPorcentajeDeCoberturaRevisado;
            }
        }
    }
}