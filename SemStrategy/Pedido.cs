namespace SemStrategy
{
    internal class Pedido
    {
        private string _tipoFrete;

        public Pedido(string t) { _tipoFrete = t; }

        public double CalcularFrete()
        {
            return _tipoFrete switch
            {
                "Terrestre" => CalcularFreteTerreste(),
                "Aereo" => CalcularFreteAereo(),
                "Maritmo" => CalcularFreteMaritmo(),
                "Express" => CalcularFreteExpress(),
                "Ferroviario" => CalcularFreteFerroviario(),
                _ => throw new Exception("Tipo de frete não encontrado")
            };
        }

        private double CalcularFreteTerreste() => 10.0f;

        private double CalcularFreteAereo() => 20.0f;

        private double CalcularFreteMaritmo() => 15.0f;

        private double CalcularFreteExpress() => 25.0f;

        private double CalcularFreteFerroviario() => 12.0f;

    }
}
