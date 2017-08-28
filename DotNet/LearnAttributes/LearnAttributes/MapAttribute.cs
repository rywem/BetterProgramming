using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnAttributes
{
    //[System.AttributeUsage(System.AttributeTargets.Property |
    //                   System.AttributeTargets.Struct,
    //                   AllowMultiple = true)]
    [System.AttributeUsage(System.AttributeTargets.Property, AllowMultiple = true)]
    public class MapAttribute : System.Attribute
    {
        public string MapsFrom { get; set; }
        public ServiceCall ServiceCall { get; set; }
               
        public MapAttribute(string MapsFrom)
        {
            this.MapsFrom = MapsFrom;
        }

        public MapAttribute(string MapsFrom, ServiceCall ServiceCall) : this(MapsFrom)
        {
            this.ServiceCall = ServiceCall;
        }
               
    }
    [Flags]
    public enum ServiceCall
    {
        CreditCardAVSOnly = 0,
        CreditCardAdjustment = 1,
        CreditCardAuthorization = 2,
        CreditCardAuthorizationCompletion = 3,
        CreditCardBalanceInquiry = 4,
        CreditCardCredit = 5,
        CreditCardForce = 6,
        CreditCardIncrementalAuthorization = 7,
        CreditCardReturn = 8,
        CreditCardReversal = 9,
        CreditCardSale = 10,
        CreditCardVoid = 11,
        DebitCardPinlessReturn = 12,
        DebitCardPinlessSale = 13,
        DebitCardReturn = 14,
        DebitCardReversal = 15,
        DebitCardSale = 16,
    }
}
