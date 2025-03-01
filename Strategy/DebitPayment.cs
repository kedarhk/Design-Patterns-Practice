namespace Payment
{
    public class DebitPayment : IPaymentMode
    {
        public void Pay()
        {
            Console.WriteLine("Debit Card Payment");
        }
    }
}