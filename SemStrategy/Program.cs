namespace SemStrategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====|e-commerce|=====");

            var p1 = new Pedido("Terrestre");
            Console.WriteLine($"Frete terrestre: {p1.CalcularFrete()}");

            var p2 = new Pedido("Aereo");
            Console.WriteLine($"Frete aéreo: {p2.CalcularFrete()}");

            var p3 = new Pedido("Maritmo");
            Console.WriteLine($"Frete marítimo: {p3.CalcularFrete()}");

            var p4 = new Pedido("Express");
            Console.WriteLine($"Frete express: {p4.CalcularFrete()}");

            var p5 = new Pedido("Ferroviario");
            Console.WriteLine($"Frete ferroviário: {p5.CalcularFrete()}");
        }
    }
}
