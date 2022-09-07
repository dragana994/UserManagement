using System.Linq;
using System.Linq.Expressions;

namespace UserManagement.Application.Extensions
{
    public static class OrderByFields
    {
        public static IQueryable<T> DynamicOrderBy<T>(this IQueryable<T> query, string sortField, bool asc)
        {
            var param = Expression.Parameter(typeof(T), sortField);
            var prop = Expression.Property(param, sortField);
            var exp = Expression.Lambda(prop, param);
            var method = asc ? "OrderBy" : "OrderByDescending";
            var types = new[] { query.ElementType, exp.Body.Type };
            var mce = Expression.Call(typeof(Queryable), method, types, query.Expression, exp);

            return query.Provider.CreateQuery<T>(mce);
        }
    }
}