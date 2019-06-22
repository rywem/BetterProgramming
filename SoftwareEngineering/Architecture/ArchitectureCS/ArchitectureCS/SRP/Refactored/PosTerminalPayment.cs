using System;
using ArchitectureCS.Objects;

namespace ArchitectureCS.SRP.Refactored
{
    public class PosTerminalPayment : PaymentModel, ICanOperateWithCash
    {
        private readonly Action onPayChangeToMobilePhone;
        private decimal _cashAccepted;
        public PosTerminalPayment(TicketDetails ticketDetails, Action onPayChangeToMobilePhone) : base(ticketDetails)
        {

        }

        public override void BuyTicket()
        {
            throw new NotImplementedException();
        }

        public void AcceptCash()
        {
            throw new NotImplementedException();
        }

        public void DispenseCharge()
        {
            throw new NotImplementedException();
        }
    }
}
