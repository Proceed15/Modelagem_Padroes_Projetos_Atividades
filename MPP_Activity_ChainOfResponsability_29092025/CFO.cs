// Os Aprovadores Concretos: CFO
    public class CFO : HandlerInterfaceManager
    {
        public override void Approve(PurchaseRequest request)
        {
            if (request.Amount <= 50000)
            {
                Console.WriteLine($"CFO aprovou: {request.Description} (R${request.Amount:F2})");
            }
            else
            {
                Console.WriteLine($"CFO: valor acima de R$50.000, requer aprovação do Conselho! Pedido: {request.Description}");
            }
        }
    }