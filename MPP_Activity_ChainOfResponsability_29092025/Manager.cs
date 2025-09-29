// UM Aprovador Concreto: Gerente
    public class Manager : HandlerInterfaceManager
    {
        public override void Approve(PurchaseRequest request)
        {
            if (request.Amount <= 1000)
            {
                Console.WriteLine($"Gerente aprovou: {request.Description} (R${request.Amount:F2})");
            }
            else
            {
                Console.WriteLine("Gerente: valor acima do limite, encaminhando...");
                base.Approve(request);
            }
        }
    }