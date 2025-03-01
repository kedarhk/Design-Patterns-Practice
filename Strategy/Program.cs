using Payment;

namespace Strategy
{
    public class Program
    {
        public static void Main(String[] args)
        {
            PaymentContext pcon = new PaymentContext();
            pcon.SetPaymentMode(new DebitPayment());
            pcon.SetPaymentMode(new CreditPayment());
            pcon.DoPayment();
            pcon.SetPaymentMode(new UPIPayment());
            pcon.DoPayment();
        }
    }
}
