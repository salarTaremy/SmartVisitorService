using SmartVisitor.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartVisitor.Repositories
{
    public class ProductRepository : BaseRepository, IBaseRepository<Product, int>, IProductRepository
    {
        public ProductRepository(string IMEI)
            :base(IMEI)
        {

        }

        public bool Create(Product item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> Get()
        {
            var Result =  Db.GetAsEnumerable<Product>("GetProduct", new { IMEI = this.IMEI}) ;
            return Result;
        }

        public Product Get(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
