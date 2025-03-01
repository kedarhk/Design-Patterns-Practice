using Payment;

namespace Strategy
{
    public class PaymentContext
    {
        private IPaymentMode _paymentMode;

        public void SetPaymentMode(IPaymentMode paymentMode)
        {
            _paymentMode = paymentMode;
        }

        public void DoPayment()
        {
            _paymentMode.Pay();
        }
    }
}