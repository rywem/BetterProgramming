using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionTreeConsole
{
    public static class EnumerableExtensions
    {
        //https://dotnetfiddle.net/5PlilF
        //https://youtu.be/Ptnxc6tVIPE?t=2376
        public static IQueryable<T> OrderByPropertyOrField<T>(this IQueryable<T> queryable, string propertyOrFieldName, bool ascending = true)
        {
            var elementType = typeof(T);
            var parameter = Expression.Parameter(elementType);
            var prop = Expression.PropertyOrField(parameter, propertyOrFieldName);
            var selector = Expression.Lambda(prop, parameter);
            var orderByMethodName = ascending ? "OrderBy" : "OrderByDescending";
            var orderByExpression = Expression.Call(
                typeof(Queryable),                  //the type whose function we want to call
                orderByMethodName,                  //the name of the method
                new[] { elementType, prop.Type },   //the generic type signature
                queryable.Expression,               //parameter
                selector);                          //parameter

            return queryable.Provider.CreateQuery<T>(orderByExpression);
        }
    }
}
