using SmartVisitor.Entities.Customer;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartVisitor.Repositories
{
    public class CustomerGroupRepository : BaseRepository, IBaseRepository<CustomerGroup, int>, ICustomerGroupRepository
    {
        public CustomerGroupRepository()
                : base(null)
        {

        }

        public bool Create(CustomerGroup item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CustomerGroup> Get()
        {
            String Query = "SELECT * FROM dbo.CustomerGroup";
            return Db.GetAsEnumerable<CustomerGroup>(Query,null,System.Data.CommandType.Text);
        }

        public CustomerGroup Get(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
