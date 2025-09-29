// Pedido de aprovação
    public class PurchaseRequest
    {
        public string Description { get; }
        public double Amount { get; }

        public PurchaseRequest(string description, double amount)
        {
            Description = description;
            Amount = amount;
        }
    }