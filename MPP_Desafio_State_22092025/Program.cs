// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("--- SIMULAÇÃO DE UM PEDIDO BEM-SUCEDIDO ---");
            Pedido pedido1 = new Pedido();
            pedido1.ProcessarPagamento();
            pedido1.DespacharPedido();
            pedido1.EntregarPedido();

            Console.WriteLine("\n--- TENTATIVA DE AÇÃO INVÁLIDA ---");
            Pedido pedido2 = new Pedido();
            pedido2.DespacharPedido(); // Tentando despachar antes de pagar

            Console.WriteLine("\n--- SIMULAÇÃO DE UM PEDIDO BEM-SUCEDIDO ---");
            Pedido pedido3 = new Pedido();
            pedido3.ProcessarPagamento();
            pedido3.DespacharPedido();
            pedido3.EntregarPedido();

            Console.WriteLine("--- SIMULAÇÃO DE UM PEDIDO BEM-SUCEDIDO ---");
            Pedido pedido4 = new Pedido();
            pedido4.ProcessarPagamento();
            pedido4.DespacharPedido();
            pedido4.EntregarPedido();

            Console.WriteLine("\n--- SIMULAÇÃO DE UM CANCELAMENTO ---");
            Pedido pedido5 = new Pedido();
            pedido5.ProcessarPagamento();
            pedido5.CancelarPedido(); // Cancelando após o pagamento, mas antes do envio
            pedido5.DespacharPedido(); // Tentando despachar um pedido cancelado

            Console.WriteLine("--- SIMULAÇÃO DE UM PEDIDO BEM-SUCEDIDO ---");
            Pedido pedido6 = new Pedido();
            pedido6.ProcessarPagamento();
            pedido6.DespacharPedido();
            pedido6.EntregarPedido();

            Console.WriteLine("--- SIMULAÇÃO DE UM PEDIDO DEVOLVIDO ---");
            Pedido pedido7 = new Pedido();
            pedido7.ProcessarPagamento();
            pedido7.DespacharPedido();
            pedido7.EntregarPedido();
            pedido7.SolicitarDevolucao();

            Console.WriteLine("--- SIMULAÇÃO DE UM PEDIDO BEM-SUCEDIDO ---");
            Pedido pedido8 = new Pedido();
            pedido8.ProcessarPagamento();
            pedido8.DespacharPedido();
            pedido8.EntregarPedido();

            Console.WriteLine("--- SIMULAÇÃO DE UM PEDIDO BEM-SUCEDIDO ---");
            Pedido pedido9 = new Pedido();
            pedido9.ProcessarPagamento();
            pedido9.DespacharPedido();
            pedido9.EntregarPedido();
        }
    }


