using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GraphLinq.Queryable
{
    public class GraphQlQueryable<T> : IQueryable<T>, IAsyncEnumerable<T>
    {
        public Type ElementType { get; set; }

        public Expression Expression { get; set; }

        public IQueryProvider Provider { get => provider; }

        private readonly GraphQlQueryProvider provider;

        public GraphQlQueryable(
            GraphQlQueryProvider provider,
            Expression expression)
        {
            this.provider = provider;
            this.Expression = expression;

            this.ElementType = typeof(T);
        }

        public IEnumerator<T> GetEnumerator()
        {
            yield return provider.Execute<T>(Expression);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            yield return provider.Execute(Expression);
        }

        public async IAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken = default)
        {
            yield return await provider.ExecuteAsync<T>(Expression);
        }
    }
}
