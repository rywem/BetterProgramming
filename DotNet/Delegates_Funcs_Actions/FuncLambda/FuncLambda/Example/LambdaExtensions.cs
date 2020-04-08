using System;
using System.Collections.Generic;
using System.Text;

namespace FuncLambda.Example
{
    public static class LambdaExtensions
    {
        public static IEnumerable<Customer> SetAccount(this IEnumerable<Customer> customers )
        {
            foreach ( var cus in customers )
            {
                cus.Account.Name = "Test";
                yield return cus;
            }
        }

        public static IEnumerable<Customer> SetAccount2( this IEnumerable<Customer> customers, Func<Customer, string> inputFunc )
        {
            foreach ( var cus in customers )
            {
                inputFunc(cus);
                yield return cus;
            }
        }

        public static IEnumerable<T> SetAccountT<T>( this IEnumerable<T> customers, Func<T, string> inputFunc )
        {
            foreach ( var cus in customers )
            {
                inputFunc(cus);
                yield return cus;
            }
        }
    }
}
