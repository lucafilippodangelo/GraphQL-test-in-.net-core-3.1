using GraphQL.Types;
using GraphQLTest.DomainObject;
using GraphQLTest.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLTest.Queries
{
    public class QueryCarBrand : ObjectGraphType
    {
        public QueryCarBrand(IInMemoryRepository anInMemoryRepository) 
        {
            Field<ListGraphType<CarBrandGraphType>>(
                "carbrands",
                 Description = "a description", 
                 resolve: context => anInMemoryRepository.GetAllCarBrandAndModels()
                );
        }
    }
}
