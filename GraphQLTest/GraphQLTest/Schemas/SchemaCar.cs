using GraphQL;
using GraphQL.Types;
using GraphQLTest.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schemas.GraphQLTest
{
    /// <summary>
    /// this method holds the three building blocks in GraphQL
    /// </summary>
    public class SchemaCar : Schema
    {
        public SchemaCar(IDependencyResolver resolver) : base (resolver)
        {
            Query = resolver.Resolve<QueryCarBrand>();
            //Mutation = resolver.Resolve<MutationCarBrand>();
        }
    }
}
