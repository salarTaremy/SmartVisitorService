using SmartVisitor.Entities.Products;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SmartVisitor.Repositories
{
    public class  ProductGroupRepository:BaseRepository,IBaseRepository<ProductGroup,int>, IProductGroupRepository
    {
        public ProductGroupRepository()
            :base(null)
        {

        }

        public bool Create(ProductGroup item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductGroup> Get()
        {
            string Qury = "SELECT * FROM dbo.ProductGroup";
            var result = Db.GetAsEnumerable<ProductGroup>(Qury, null, CommandType.Text);
            return result;
        }

        public ProductGroup Get(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
