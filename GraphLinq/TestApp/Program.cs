using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using TestApp.Context;

namespace TestApp
{
    class Program
    {
        private class Test
        {
            public string firstName;
            public string lastName;
            public string middleName;
        }

        static void Main(string[] args)
        {
            GraphQlContext @base = new ();

            var query = @base.CreateQuery<Test>();

            query
                .Where(x => x.firstName == "Luna")
                .Select(x => x.lastName)
                .ToListAsync();
        }
    }
}
