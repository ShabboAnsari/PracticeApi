using Microsoft.EntityFrameworkCore;
using PracticeApi.Context;
using PracticeApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PracticeApi.Repository
{
    public class ProductRepository:BaseRepository, IProductRepository
    {
        public ProductRepository(SqlContext context):base(context)
        {
                
        }
        public async Task<IEnumerable<Products>> ListAsync()
        {
            return await _context.Products.ToListAsync();
        }
    }
}
