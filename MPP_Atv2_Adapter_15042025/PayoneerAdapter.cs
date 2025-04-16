public class PayoneerAdapter : IPaymentSystem
{
    private readonly Payoneer payoneer;

    public PayoneerAdapter(Payoneer payoneer)
    {
        this.payoneer = payoneer;
    }

    public void paypalPayment()
    {
        payoneer.sendPayment();
    }

    public void paypalReceive()
    {
        payoneer.receivePayment();
    }
}