public class MercadoPagoAdapter : IPaymentSystem
{
    private readonly MercadoPago mercadoPago;

    public MercadoPagoAdapter(MercadoPago mercadoPago)
    {
        this.mercadoPago = mercadoPago;
    }

    public void paypalPayment()
    {
        mercadoPago.doThePayment();
    }

    public void paypalReceive()
    {
        mercadoPago.receiveThePayment();
    }
}