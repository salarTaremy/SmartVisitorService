using SmartVisitor.Entities.Products;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SmartVisitor.Repositories
{
    public class ProductBrandRepository:BaseRepository,IBaseRepository<ProductBrand , int>, IProductBrandRepository
    {
        public ProductBrandRepository()
            :base(null)
        {

        }

        public bool Create(ProductBrand item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductBrand> Get()
        {
            string Qury = "SELECT * FROM dbo.ProductBrand";
            var result = Db.GetAsEnumerable<ProductBrand>(Qury, null, CommandType.Text);
            return result;
        }

        public ProductBrand Get(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
