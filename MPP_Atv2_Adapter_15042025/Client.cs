public class Client
{
    private IPaymentSystem paymentSystem;

    public Client(IPaymentSystem paymentSystem)
    {
        this.paymentSystem = paymentSystem;
    }

    public void MakeTransaction()
    {
        paymentSystem.paypalPayment();
        paymentSystem.paypalReceive();
    }
}