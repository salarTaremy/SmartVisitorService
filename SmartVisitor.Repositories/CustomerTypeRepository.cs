using SmartVisitor.Entities.Customer;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartVisitor.Repositories
{
    public class CustomerTypeRepository : BaseRepository, IBaseRepository<CustomerType, int>, ICustomerTypeRepository
    {
        public CustomerTypeRepository()
            :base(null)
        {

        }

        public bool Create(CustomerType item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CustomerType> Get()
        {
            String Query = "SELECT * FROM dbo.CustomerType";
            return Db.GetAsEnumerable<CustomerType>(Query, null, System.Data.CommandType.Text);
        }

        public CustomerType Get(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
