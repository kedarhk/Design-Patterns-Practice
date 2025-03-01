namespace Payment
{
    public class CreditPayment : IPaymentMode
    {
        public void Pay()
        {
            Console.WriteLine("Credit Card Payment");
        }
    }
}