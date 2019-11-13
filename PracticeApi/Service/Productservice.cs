using PracticeApi.Models;
using PracticeApi.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PracticeApi.Service
{
    public class Productservice:IProductService
    {
        private readonly IProductRepository _productRepository;
            public Productservice(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<IEnumerable<Products>> ListAsync()
        {
            return await _productRepository.ListAsync();
        }
    }
}
