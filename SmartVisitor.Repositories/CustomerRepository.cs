using SmartVisitor.Entities.Customer;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartVisitor.Repositories
{
    public class CustomerRepository : BaseRepository  ,IBaseRepository<Customer , int>, ICustomerRepository
    {
        
        public CustomerRepository(string IMEI) 
            :base(IMEI)
        {

        }

        public bool Create(Customer item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> Get()
        {
            return Db.GetAsEnumerable<Customer>("GetCustomer", new { IMEI = this.IMEI });
        }

        public Customer Get(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
