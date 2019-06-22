using System;
using ArchitectureCS.Objects;

namespace ArchitectureCS.SRP.Refactored
{
    public interface ICanPayViaCreditCard
    {
        void ChargeCard(TicketDetails ticketDetails, PaymentDetails paymentDetails);
    }
}
