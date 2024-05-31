namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====|e-commerce|=====");

            var p1 = new Pedido(new FreteTerrestre());
            Console.WriteLine($"Frete terrestre: {p1.TipoFrete.CalcularFrete()}");

            var p2 = new Pedido(new FreteAereo());
            Console.WriteLine($"Frete aéreo: {p2.TipoFrete.CalcularFrete()}");

            var p3 = new Pedido(new FreteMaritimo());
            Console.WriteLine($"Frete marítimo: {p3.TipoFrete.CalcularFrete()}");

            var p4 = new Pedido(new FreteExpress());
            Console.WriteLine($"Frete express: {p4.TipoFrete.CalcularFrete()}");

            var p5 = new Pedido(new FreteFerroviario());
            Console.WriteLine($"Frete ferroviário: {p5.TipoFrete.CalcularFrete()}");
        }
    }
}
