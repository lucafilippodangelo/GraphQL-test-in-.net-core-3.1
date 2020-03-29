using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLTest.DomainObject
{
    /// <summary>
    /// This method maps the domain object
    /// </summary>
    public class CarBrandGraphType : ObjectGraphType<CarBrand>
    {
        public CarBrandGraphType()
        {
            Field(t => t.Name);
            Field(t => t.SecurityRate).Description ("how secure is this car brand");
            //Field(t => t.CarModels);
        }
    }
}
