using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLTest.DomainObject
{
    public class CarBrand
    {
        public string Name { get; set; }
        public int SecurityRate { get; set; }
        public IEnumerable<CarModel> CarModels { get; set; }
    }
}
