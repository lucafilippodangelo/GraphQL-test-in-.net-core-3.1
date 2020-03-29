using GraphQLTest.DomainObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLTest.Repositories
{
    public interface IInMemoryRepository
    {
        Task<IEnumerable<CarBrand>> GetAllCarBrandAndModels();
    }

    public class InMemoryRepository : IInMemoryRepository
    {
        private IEnumerable<CarModel> CreateCarModelsFord()
        {
            IEnumerable<CarModel> aCarModelList = new List<CarModel>()
            {
                new CarModel(){ Name = "Fiesta", ChassyType = "Hatch" },
                new CarModel() { Name = "Focus", ChassyType = "Family" },
                new CarModel() { Name = "Mondeo", ChassyType = "Saloon" }
            };
            return aCarModelList;
        }

        private IEnumerable<CarModel> CreateCarModelsFiat()
        {
            IEnumerable<CarModel> aCarModelList = new List<CarModel>()
            {
                new CarModel(){ Name = "500", ChassyType = "Hatch" },
                new CarModel() { Name = "Stilo", ChassyType = "Family" },
            };
            return aCarModelList;
        }

        public async Task<IEnumerable<CarBrand>> GetAllCarBrandAndModels()
        {
            IEnumerable<CarBrand> aCarBrandList = new List<CarBrand>()
            {
                new CarBrand(){ Name = "Ford", SecurityRate = 4, CarModels = CreateCarModelsFord() },
                new CarBrand(){ Name = "Fiat", SecurityRate = 3, CarModels = CreateCarModelsFiat() },
            };
            return aCarBrandList;
        }
    }
}
