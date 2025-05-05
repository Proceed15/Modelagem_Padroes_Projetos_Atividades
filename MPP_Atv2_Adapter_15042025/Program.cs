// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Registro de Transações:");
        var paypal = new PayPal();
        var clientWithPayPal = new Client(paypal);
        Console.WriteLine("\nTransação com PayPal:");
        clientWithPayPal.MakeTransaction();

        var payoneer = new Payoneer();
        //Adaptador usando o valor de Payoneer das operações sendPayment e ReceivePayment
        var payoneerAdapter = new PayoneerAdapter(payoneer);
        var clientWithPayoneer = new Client(payoneerAdapter);
        Console.WriteLine("\nTransação com Payoneer:");
        clientWithPayoneer.MakeTransaction();

        var mercadoPago = new MercadoPago();
        //Adaptador usando o valor de MercadoPago das operações doThePayment e ReceiveThePayment
        var mercadoPagoAdapter = new MercadoPagoAdapter(mercadoPago);
        var clientWithMercadoPago = new Client(mercadoPagoAdapter);
        Console.WriteLine("\nTransação com MercadoPago:");
        clientWithMercadoPago.MakeTransaction();
    }
}