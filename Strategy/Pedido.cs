namespace Strategy
{
    public class Pedido
    {
        public IFreteStrategy TipoFrete { get; }

        public Pedido(IFreteStrategy t)
        {
            TipoFrete = t;
        }
    }
}
