public class PayPal : IPaymentSystem
{
    public void paypalPayment()
    {
        Console.WriteLine("Realizando pagamento via PayPal.");
    }

    public void paypalReceive()
    {
        Console.WriteLine("Recebendo pagamento via PayPal.");
    }
}