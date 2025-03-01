namespace Payment
{
    public class UPIPayment : IPaymentMode
    {
        public void Pay()
        {
            Console.WriteLine("UPI Payment");
        }
    }
}