using GraphLinq.Queryable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphLinq.Context
{
    public abstract class GraphQlContextBase
    {
        private GraphQlQueryProvider queryProvider;

        public GraphQlContextBase()
        {
            queryProvider = new GraphQlQueryProvider();
        }

        public IQueryable<T> CreateQuery<T>()
        {
            var temp = new List<T>().AsQueryable();

            return queryProvider.CreateQuery<T>(temp.Expression);
        }
    }
}
