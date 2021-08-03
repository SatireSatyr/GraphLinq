using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GraphLinq.Queryable
{
    public class GraphQlQueryProvider : IQueryProvider
    {
        public IQueryable CreateQuery(Expression expression)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TElement> CreateQuery<TElement>(Expression expression)
        {
            return new GraphQlQueryable<TElement>(this, expression);
        }

        public Task<object> ExecuteAsync(Expression expression)
        {
            throw new NotImplementedException();
        }

        public async Task<TResult> ExecuteAsync<TResult>(Expression expression)
        {
            return (TResult) await ExecuteAsync(expression);
        }

        public object Execute(Expression expression)
        {
            return ExecuteAsync(expression).GetAwaiter().GetResult();
        }

        public TResult Execute<TResult>(Expression expression)
        {
            return ExecuteAsync<TResult>(expression).GetAwaiter().GetResult();
        }
    }
}
